'use strict';

function solve(params){
    let points = params.slice(0).map(Number),
        p1,p2,p3,p4,p5,p6,l1,l2,l3,result;


function point(x,y){
    this.x = x;
    this.y = y;
}

function line(start, end){
    this.start = start;
    this.end = end;
}

line.prototype.length = function (){
    let a = (this.start.x - this.end.x) * (this.start.x - this.end.x);
    let b = (this.start.y - this.end.y) * (this.start.y - this.end.y);
    return Math.sqrt(a+b);
};

function formTriangle(a,b,c){
    return  a.length() < b.length() + c.length() && 
            b.length() < a.length() + c.length() &&
            c.length() < a.length() + b.length();
}

    p1 = new point(points[0], points[1]);
    p2 = new point(points[2], points[3]);
    p3 = new point(points[4], points[5]);
    p4 = new point(points[6], points[7]);
    p5 = new point(points[8], points[9]);
    p6 = new point(points[10], points[11]);

    l1 = new line(p1, p2);
    console.log(l1.length(p1, p2).toFixed(2));
    l2 = new line(p3, p4);
    console.log(l2.length(p1, p2).toFixed(2));
    l3 = new line(p5, p6);
    console.log(l3.length(p1, p2).toFixed(2));

    result = formTriangle(l1, l2, l3) ? 'Triangle can be built' : 'Triangle can not be built';
    console.log(result);
}

solve([
  '5', '6', '7', '8',
  '1', '2', '3', '4',
  '9', '10', '11', '12'
]);

solve([
  '7', '7', '2', '2',
  '5', '6', '2', '2',
  '95', '-14.5', '0', '-0.123'
]);