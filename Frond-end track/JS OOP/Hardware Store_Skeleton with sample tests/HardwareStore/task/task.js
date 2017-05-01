function solve() {

const VALIDATOR = {
	isString: function(x) {
        if(typeof x !== 'string') {
          throw Error('Not a string');
        }
      },
      isInRange: function(x, min, max, err) {
        if(x < min || x > max || Number.isNaN(x)) {
          throw Error('Not in range');
        }
      },
      isLengthInRange1_10: function(x) {
        this.isInRange(x.length, 1, 10, 'Length not in range 1-10');
      },
	   isLengthInRange1_20: function(x) {
        this.isInRange(x.length, 1, 20, 'Length not in range 1-20');
      },
	  isNumber:function(x){
		  if(Number.isNaN(x)){
			  throw Error('Not a number');
		  }
	  },
	  isPositiveNumber: function(x){
		  if(x<=0){
			  throw Error('Not a positive number');
		  }
	  },
	  isIntegerNumber: function(x){
		  if(Number(x) === x && x % 1 !== 0){
			  throw Error('Not an integer number');
		  }
	  },
	  isValidQuality: function(x){
		  if(x!=='high'&&x!=='mid'&&x!=='low'){
			  throw Error('Invalid quality');
		  }
	  }
};

 const getNextId = (function() {
      let counter = 0;
      return function() {
        counter += 1;
        return counter;
      };
    })();

class Product{
	constructor(manufacturer, model, price){
		this._id = getNextId();
		this.manufacturer = manufacturer;
		this.model = model;
		this.price = price;
	}

	get id() {
        return this._id;
      }

	get manufacturer(){
		return this._manufacturer;
	}
	set manufacturer(manufacturer){
		VALIDATOR.isString(manufacturer);
		VALIDATOR.isLengthInRange1_20(manufacturer);
		this._manufacturer = manufacturer;
	}
	get model(){
		return this._model;
	}
	set model(model){
		VALIDATOR.isString(model);
		VALIDATOR.isLengthInRange1_20(model);
		this._model = model;
	}
	get price(){
		return this._price;
	}
	set price(price){
		VALIDATOR.isNumber(price);
		VALIDATOR.isPositiveNumber(price);
		this._price = price;
	}

	getLabel(){
		return this.constructor.name + ' - '+ this.manufacturer + ' - **' + this.price+'**';
	}	
}

class SmartPhone extends Product{
	constructor(manufacturer, model, price, screenSize, operatingSystem){
		super(manufacturer, model, price);
		this.screenSize = screenSize;
		this.operatingSystem = operatingSystem;
	}

	get screenSize(){
		return this._screenSize;
	}
	set screenSize(screenSize){
		VALIDATOR.isNumber(screenSize);
		VALIDATOR.isPositiveNumber(screenSize);
		this._screenSize = screenSize;
	}
	get operatingSystem(){
		return this._operatingSystem;
	}
	set operatingSystem(operatingSystem){
		VALIDATOR.isString(operatingSystem);
		VALIDATOR.isLengthInRange1_10(operatingSystem);
		this._operatingSystem = operatingSystem;
	}
}

class Charger extends Product{
	constructor(manufacturer, model, price, outputVoltage, outputCurrent){
		super(manufacturer, model, price);
		this.outputVoltage = outputVoltage;
		this.outputCurrent = outputCurrent;
	}
	get outputVoltage(){
		return this._outputVoltage;
	}
	set outputVoltage(outputVoltage){
		VALIDATOR.isNumber(outputVoltage);
		VALIDATOR.isInRange(outputVoltage, 5, 20, 'Not in range 5-20');
		this._outputVoltage = outputVoltage;
	}
	get outputCurrent(){
		return this._outputCurrent;
	}
	set outputCurrent(outputCurrent){
		VALIDATOR.isNumber(outputCurrent);
		VALIDATOR.isInRange(outputCurrent, 100, 3000, 'Not in range 100-3000');
		this._outputCurrent = outputCurrent;
	}
}

class Router extends Product{
	constructor(manufacturer, model, price, wifiRange, lanPorts){
		super(manufacturer, model, price);
		this.wifiRange = wifiRange;
		this.lanPorts = lanPorts;
	}
	get wifiRange(){
		return this._wifiRange;
	}
	set wifiRange(wifiRange){
		VALIDATOR.isNumber(wifiRange);
		VALIDATOR.isPositiveNumber(wifiRange);
		this._wifiRange = wifiRange;
	}
	get lanPorts(){
		return this._lanPorts;
	}
	set lanPorts(lanPorts){
		VALIDATOR.isNumber(lanPorts);
		VALIDATOR.isPositiveNumber(lanPorts);
		VALIDATOR.isIntegerNumber(lanPorts);
		this._lanPorts = lanPorts;
	}
}

class Headphones extends Product{
	constructor(manufacturer, model, price, quality, hasMicrophone){
		super(manufacturer, model, price);
		this.quality = quality;
		this.hasMicrophone = hasMicrophone;
	}

	get quality(){
		return this._quality;
	}
	set quality(quality){
		VALIDATOR.isValidQuality(quality);
		this._quality = quality;
	}
	get hasMicrophone(){
		return this._hasMicrophone;
	}
	set hasMicrophone(hasMicrophone){
		this._hasMicrophone = !!hasMicrophone;
	}
}
class HardwareStore{
	constructor(name){
		this.name = name;
		this._products = [];
	}

	get products(){
		return this._products;
	}
	get name(){
		return this._name;
	}
	set name(name){
		VALIDATOR.isString(name);
		VALIDATOR.isLengthInRange1_20(name);
		this._name = name;
	}

	stock(product, quantity){
		if(!(product instanceof Product)){
			throw Error('Invaid instance of Product');
		}
		VALIDATOR.isNumber(quantity);
		VALIDATOR.isPositiveNumber(quantity);

		let productObject = {
			_id: product._id,
			product: product,
			quantity:quantity,
			manufacturer:product.manufacturer,
			model: product.model,
			price: product.price
		};

		this._products.push(productObject);

		return this;
	}

	sell(productId, quantity){
		VALIDATOR.isNumber(quantity);
		VALIDATOR.isPositiveNumber(quantity);

		const index = this._products.findIndex(p => p._id === productId);
		if (index < 0) {
			throw Error('There isn`t such product');
		}

		if (this._products[index].quantity < quantity) {
			throw Error('Not enough quantity');
		}
		else if (this._products[index].quantity === quantity) {
			this._products.splice(index, 1);
		}
		else {
			this._products[index].quantity -= quantity;
		}

		return this;
	}

	getSold(){

	}

	search(pattern){
		let resultProducts = [];
		for (const product of this.products) {
                if (product.manufacturer.toLowerCase().includes(pattern.toLowerCase())||product.model.toLowerCase().includes(pattern.toLowerCase())) {
					resultProducts.push({product:product.product, quantity:product.quantity});
                }
            }

		return resultProducts;
	}
}

	return {
		getSmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
			return new SmartPhone(manufacturer, model, price, screenSize, operatingSystem);
		},
		getCharger(manufacturer, model, price, outputVoltage, outputCurrent) {
			return new Charger(manufacturer, model, price, outputVoltage, outputCurrent);
		},
		getRouter(manufacturer, model, price, wifiRange, lanPorts) {
			return new Router(manufacturer, model, price, wifiRange, lanPorts);
		},
		getHeadphones(manufacturer, model, price, quality, hasMicrophone) {
			return new Headphones(manufacturer, model, price, quality, hasMicrophone);
		},
		getHardwareStore(name) {
			return new HardwareStore(name);
		}
	};
}

// Submit the code above this line in bgcoder.com
module.exports = solve; // DO NOT SUBMIT THIS LINE

const result = solve();

const phone = result.getSmartPhone('HTC', 'One', 903, 5, 'Android');

console.log(phone.getLabel()); // SmartPhone - HTC One - **903**

const headphones = result.getHeadphones('Sennheiser', 'PXC 550 Wireless', 340, 'high', false);
const store = result.getHardwareStore('Magazin');

store.stock(phone, 1)
    .stock(headphones, 15);

console.log(store.products);
console.log('====================')
console.log(store.search('senn'));



// console.log('===================')
// store.sell(headphones.id, 3);
// console.log(store.products);
// console.log(store.splicedProducts);



// var module = solve();

// let smartPhone = module.getSmartPhone('phoneManufacturer', 'phonemodel', 234, 12, 'ios');
// console.log(smartPhone.getLabel());

// let charger = module.getCharger('chargerManufacturer', 'chargermodel', 2345, 15, 2000);
// console.log(charger.getLabel());

// let router = module.getRouter('routerManufacturer', 'routermodel', 97678, 347, 45 );
// console.log(router.getLabel());

// let store = module.getHardwareStore('store1');
// store.stock(router, 5);
// console.log(store.products);