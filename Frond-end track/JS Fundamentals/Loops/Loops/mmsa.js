'use strict';

function solve() {
let primes = [];
		for(let i = 0; i<arguments.length; i+=1){
			if(Number.isNaN(Number(arguments[i]))){
				throw '';
			}
		}
		if(arguments.length!=2){
			throw '';
		}

		for(let n=arguments[0]; n<arguments[1]; n+=1){
			for(let j=1; j<Math.sqrt(arguments[1]); j+=1){
				if(n%j===0){
					primes.push(n);
				}
			}
		}
		console.log(primes);
}

solve(['2', '5', '1']);