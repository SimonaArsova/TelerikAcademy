/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function solve() {
	return function findPrimes(min, max) {
		let numbers = [], i, j, k, primes = [];
		min = +min;
		max = +max;
		if(isNaN(min)|| isNaN(max)){
			throw '';
		}

		for (let k = min; k <= max; k += 1) {
			if (isPrime(k)) {
				primes.push(k);
			}
		}
		return primes;

		function isPrime(number) {
			if(number<2){
				return false;
			}
			if(number===2){
				return true;
			}
			for(i=2; i<=Math.sqrt(number); i+=1){
				if(number%i===0){
					return false;
				}
			}
			return true;
		}

	};
}

module.exports = solve;
