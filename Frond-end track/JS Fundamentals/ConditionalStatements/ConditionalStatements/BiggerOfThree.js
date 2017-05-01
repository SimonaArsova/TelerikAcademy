function solve(args){
   let a,b,c,max;
   a = +args[0];
   b = +args[1];
   c = +args[2];

   if((a >= b) && (a >= c)){
       max = a;
   }
   else if((b >= a) && (b >= c)){
     max = b;
   }
   else{
       max = c;
   }
   console.log(max);
   
}
solve(['4','7','1']);