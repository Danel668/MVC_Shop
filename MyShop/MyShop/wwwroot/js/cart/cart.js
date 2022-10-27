var app = new Vue({
    el: '#app',
    data: {
        loading: false,
        allQty: 0,
    },
    mounted() {

    },
    methods: {
        addOneToCart(stockId, price) {
            this.loading = true;
            axios.post("/Cart/AddOne/" + stockId)
                .then(res => {
                    console.log(res);
                    var id = stockId;
                    var el = document.getElementById(id);
                    var qty = parseInt(el.innerText);
                    if (qty < this.allQty) {
                        el.innerText = (qty + 1);
                        var id = "price-" + stockId;
                        var el = document.getElementById(id);
                        var pr = parseInt(el.innerText);
                        el.innerText = (pr + price);
                    }
                    else {
                        alert("Недостаточно товара");
                    }

                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        removeOneFromCart(stockId, price) {
            this.loading = true;
            axios.post("/Cart/RemoveOne/" + stockId)
                .then(res => {
                    console.log(res);
                    var id = stockId;
                    var el = document.getElementById(id);
                    var qty = parseInt(el.innerText);
                    if (qty == 1) {
                        var id = "product-" + stockId;
                        var el = document.getElementById(id);
                        el.outerHTML = "";
                    }
                    else {
                        el.innerText = (qty - 1);
                        var id = "price-" + stockId;
                        var el = document.getElementById(id);
                        var pr = parseInt(el.innerText);
                        el.innerText = (pr - price);
                    }
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        removeAllFromCart(stockId) {
            this.loading = true;
            axios.post("/Cart/RemoveAll/" + stockId)
                .then(res => {
                    console.log(res);
                    var id = "product-" + stockId;
                    var el = document.getElementById(id);
                    el.outerHTML = "";
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        getAllQty(allQty) {
            this.allQty = allQty;
        }
    }
})