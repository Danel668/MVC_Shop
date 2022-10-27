var app = new Vue({
    el: '#app',
    data: {
        loading: false,
        status: null,
        products: [],
        errorsNew: [],
        errorsUpd: [],
        selectedProduct: null,
        newStock: {
            productId: 0,
            qty: 10,
            color: 0,
            size: 0,
        }

    },
    mounted() {
        this.getStock();
    },
    methods: {
        getStock() {
            this.loading = true;
            axios.get("/stock")
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        selectProduct(product) {
            this.selectedProduct = product;
            this.newStock.productId = product.id;
        },
        addStock() {
            this.loading = true;
            this.errorsNew = [];
            if (this.newStock.qty <= 0 || !Number.isInteger(this.newStock.qty) || !this.newStock.qty) {
                this.errorsNew.push("Количество не может быть таким");
            }
            else {
                axios.post("/stock", this.newStock)
                    .then(res => {
                        console.log(res);
                        this.getStock();
                        this.selectedProduct = res.data;
                    })
                    .catch(err => {
                        console.log(err);
                    })
                    .then(() => {
                        this.loading = false;
                    });
            }
        },
        updateStock() {
            this.loading = true;
            this.errorsUpd = [];
            if (this.selectedProduct.stock.find(x => x.qty <= 0)) {
                this.errorsUpd.push("Количество не может быть таким");
            }
            else {
                axios.put("/stock", {
                    stock: this.selectedProduct.stock.map(x => {
                        return {
                            id: x.id,
                            qty: x.qty,
                            color: x.color,
                            size: x.size,
                            productId: this.newStock.productId
                        };
                    })
                })
                    .then(res => {
                        console.log(res);
                        this.getStock();
                        this.selectedProduct = res.data;
                        this.selectedProduct.stock.splice(index, 1);
                    })
                    .catch(err => {
                        console.log(err);
                    })
                    .then(() => {
                        this.loading = false;
                    });
            }
        },

        deleteStock(id, index) {
            this.loading = true;
            axios.delete("/stock/" + id)
                .then(res => {
                    console.log(res);
                    this.selectedProduct.stock.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
    }
})