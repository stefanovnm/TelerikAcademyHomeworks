function solve(args) {
    'use strict';

    let k = Number(args[0].split(' ')[1]),
        numbers = args[1].split(' ').map(Number);
    
    console.log(numbers);

    function transform(num, left, right) {
        if (num == 0) {
            return Math.abs(left - right);
        } else if (num%2 == 0){
            return Math.max(left, right);
        } else if(num===1){
            return left+right;
        } else {
            return Math.min(left,right);
        }
    }

    for(let i = 0; i < k; i+=1 ){
        let currentTransformation = [];

        for(let j=0; j <numbers.length; j+=1){
            let nextValue;

            if(j===0){
                nextValue = transform(numbers[j], numbers[(numbers.length -1)], numbers[(j+1)]);
            }else if(j===(numbers.length -1)){
                nextValue = transform(numbers[j], numbers[j-1], numbers[0]);
            }else{
                nextValue= transform(numbers[j], numbers[j-1], numbers[j+1]);
            }
            
            currentTransformation.push(nextValue);
        }

        numbers = currentTransformation;
    }

    let sum = 0;

    for (let num of numbers){
        sum+=num;
    }

    console.log(sum);
}



solve([
    '5 1',
    '9 0 2 4 1'
]);


