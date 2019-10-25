let a = 0;
let b = false;
if (a===b){
    console.log("a === b");
} else{
    console.log("a !=== b");
}


let num = 255;

alert( num.toString(16) );  // ff
alert( num.toString(2) );   // 11111111


let ab = +prompt("Введите первое число", "");
let ba = +prompt("Введите второе число", "");

alert( ab + ba );

function readNumber() {
    let number;
  
    do {
      number = prompt("Введите число", 0);
    } while ( !isFinite(number) );
  
    if (number === null || number === '') return null;
  
    return +number;
  }
  
  alert(`Число: ${readNumber()}`);