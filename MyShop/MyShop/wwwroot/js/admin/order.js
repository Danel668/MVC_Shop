var app = new Vue({
    el: '#app',
    data: {
        loading: false,
        status: 0,
        orders: [],
        selectedOrder: null,
        maxStatus: "Completed",
    },

    mounted() {
        this.getOrders();
    },

    watch: {
        status: function () {
            this.getOrders();
        }
    },

    methods: {
        getOrders() {
            this.loading = true;
            axios.get("/order/" + this.status)
                .then(res => {
                    console.log(res);
                    this.orders = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        getOrder(id) {
            this.loading = true;
            axios.get("/order/id/" + id)
                .then(res => {
                    console.log(res);
                    this.selectedOrder = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        exitOrder() {
            this.selectedOrder = null;
        },

        updateOrder() {
            this.loading = true;
            axios.put("/order/" + this.selectedOrder.id)
                .then(res => {
                    this.exitOrder();
                    this.getOrders();
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },


    },
})