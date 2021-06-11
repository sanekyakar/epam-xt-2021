function Service() {
    this.collection = [];
    this.add = (obj) => {
        this.collection.push(obj);
        return this;
    }
    this.getById = (id) => {
        return this.collection.find(item => item.id === id);
    }
    this.getAll = () => {
        return this.collection;
    }
    this.deleteById = (id) => {
        this.collection = this.collection.filter(item => item.id != id)
    }
    this.updateById = (id, obj) => {
        this.collection = this.collection.map(item => {
            if (item.id === id) {
                return { ...item, ...obj }
            }
            return item;

        })
    }
    this.replaceById = (id, obj) => {
        this.collection = this.collection.map(item => {
            if (item.id === id) {
                return obj
            }
            return item;

        })
    }

}

var storage = new Service();
storage.add({ id: 1 })
console.log(storage.getById(1));
console.log(storage.getAll());

