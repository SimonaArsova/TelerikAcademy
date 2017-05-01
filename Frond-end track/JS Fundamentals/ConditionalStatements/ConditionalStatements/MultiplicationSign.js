function solve (args){
    let number,
        negaviteNumbers = 0;
    for(let i=0;i<3;i+=1){
        number = +args[i];
        if(number === 0){
            console.log(0);
            return;
        }
        else{
            if(number < 0){
                negaviteNumbers++;
            }
        }
    }
    if(negaviteNumbers%2 === 0){
        console.log('+');
    }
    else{
        console.log('-');
    }
}