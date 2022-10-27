var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        productModel: {
            id: 0,
            name: "",
            category: "",
            shortDescription: "",
            description: "",
            price: 0,
            image: '',
            currentImage: '',
        },
        products: [],
        errors: [],
    },
    mounted() {
        this.getProducts();
    },
    methods: {
        handleFileUpload() {
            this.productModel.image = this.$refs.file.files[0];
            console.log(this.productModel.image);
        },

        getProducts() {
            this.loading = true;
            axios.get("/product")
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

        getProduct(id) {
            this.loading = true;
            axios.get("/product/" + id)
                .then(res => {
                    console.log(res);
                    var product = res.data;
                    this.productModel = {
                        id: id,
                        name: product.name,
                        category: product.category,
                        shortDescription: product.shortDescription,
                        description: product.description,
                        price: product.price,
                        currentImage: product.currentImage
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        updateProduct() {
            this.loading = true;
            this.errors = [];
            if (!this.productModel.name || !this.productModel.category || !this.productModel.shortDescription
                || !this.productModel.description || !this.productModel.price) {
                this.errors.push("Не все поля заполнены");
            }
            else if (this.productModel.price <= 0) {
                this.errors.push("Цена не может быть такой");
            }
            else {
                let formData = new FormData();
                formData.append('Image', this.productModel.image);
                formData.append('Id', this.productModel.id);
                formData.append('Name', this.productModel.name);
                formData.append('Category', this.productModel.category);
                formData.append('ShortDescription', this.productModel.shortDescription);
                formData.append('Description', this.productModel.description);
                formData.append('Price', this.productModel.price);
                formData.append('CurrentImage', this.productModel.currentImage);
                axios.put("/product", formData, {
                    headers: {
                        'Content-Type': 'multipart/form-data'
                    }
                })
                    .then(res => {
                        console.log(res.data);
                        this.products.splice(this.objectIndex, 1, res.data);
                    })
                    .catch(err => {
                        console.log(err);
                    })
                    .then(() => {
                        this.productModel = {
                            id: 0,
                            name: "",
                            category: "",
                            shortDescription: "",
                            description: "",
                            price: 0,
                            image: '',
                            currentImage: '',
                        };
                        this.loading = false;
                        this.editing = false;
                    });

            }
        },

        editProduct(id, index) {
            this.objectIndex = index;
            this.getProduct(id);
            this.editing = true;
        },
       
        createProduct() {
            this.loading = true;
            this.errors = [];
            if (!this.productModel.name || !this.productModel.category || !this.productModel.shortDescription
                || !this.productModel.description || !this.productModel.price || !this.productModel.image) {
                this.errors.push("Не все поля заполнены");
            }
            else if (this.productModel.price <= 0) {
                this.errors.push("Цена не может быть такой");
            }
            else if (this.products.find(n => n.name == this.productModel.name)) {
                this.errors.push("Данное название предмета уже существует");
            }
            else {
                let formData = new FormData();
                formData.append('Image', this.productModel.image);
                formData.append('Name', this.productModel.name);
                formData.append('Category', this.productModel.category);
                formData.append('ShortDescription', this.productModel.shortDescription);
                formData.append('Description', this.productModel.description);
                formData.append('Price', this.productModel.price);
                axios.post("/product", formData, {
                    headers: {
                        'Content-Type': 'multipart/form-data'
                    }
                })
                    .then(res => {
                        console.log(res.data);
                        this.products.push(res.data);
                    })
                    .catch(err => {
                        console.log(err);
                    })
                    .then(() => {
                        this.loading = false;
                        this.editing = false;
                    });
            }
        },
        deleteProduct(id, index) {
            this.loading = true;
            axios.delete("/product/" + id)
                .then(res => {
                    console.log(res);
                    this.products.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newProduct() {
            this.editing = true;
        },
        cancel() {
            this.editing = false;
            this.productModel = {
                id: 0,
                name: "",
                category: "",
                shortDescription: "",
                description: "",
                price: 0,
                image: '',
                currentImage: '',
            };
        },
    }
})