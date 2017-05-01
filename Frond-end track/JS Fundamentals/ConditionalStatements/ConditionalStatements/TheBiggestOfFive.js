'use strict';

function solve(args){
    let a,b,c,d,e,result;
    a = +args[0];
    b = +args[1];
    c = +args[2];
    d = +args[3];
    e = +args[4];

    if (a >= b) {
        if (a >= c) {
            if (a >= d) {
                if (a >= e) {
                    result = a;
                } else {
                    result = e;
                }
            } else {
                if (d >= e) {
                    result = d;
                } else {
                    result = e;
                }
            }
        } else {
            if (c >= d) {
                if (c >= e) {
                    result = c;
                } else {
                    result = e;
                }
            } else {
                if (d >= e) {
                    result = d;
                } else {
                    result = e;
                }
            }
        }
    } else {
        if (b >= c) {
            if (b >= d) {
                if (b >= e) {
                    result = b;
                } else {
                    result = e;
                }
            } else {
                if (d >= e) {
                    result = d;
                } else {
                    result = e;
                }
            }
        } else {
            if (c >= d) {
                if (c >= e) {
                    result = c;
                } else {
                    result = e;
                }
            } else {
                if (d >= e) {
                    result = d;
                } else {
                    result = e;
                }
            }
        }
    }

   console.log(result);


}
solve(['-2', '-22', '1', '0', '0']);
solve(['0', '-2.5', '0', '5', '5']);
solve(['-3', '-0.5', '-1.1', '-2', '-0.1']);