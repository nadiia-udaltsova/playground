/*let a = 0;
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
  
  alert(`Число: ${readNumber()}`);*/

  var subject = "Just a string";
  var probe = typeof subject;
  console.log (probe);

  var test1 = "abcdf";
  var test2 = 123;
  var test3 = true;
  var test4 = {};
  var test5 = [];
  var test6;
  var test7 = {"abcdef": 123};
  var test8 = ["abcdef", 123];
  function test9(){return "abcdef"};

console.log(typeof test1);
console.log(typeof test2);
console.log(typeof test3);
console.log(typeof test4);
console.log(typeof test5);
console.log(typeof test6);
console.log(typeof test7);
console.log(typeof test8);
console.log(typeof test9);

var test10 = null;
console.log(typeof test10);

if (99 == "99") {
  console.log("A number equals a string!");
  } else {
  console.log("No way a number equals a string");
  }



  function findCarInLot(car) {
    for (var i = 0; i<lot.length; i++) {
      if (car == lot[i]) {
        return i;
      }
    }
    return -1;
  }
  var chevy = {
    make: "Chevy",
    model: "Bel Air"
    };
    var taxi = {
    make: "Webville Motors",
    model: "Taxi"
    };
    var fiat1 = {
    make: "Fiat",
    model: "500"
    };
    var fiat2 = {
    make: "Fiat",
    model: "500"
    };
    var lot = [chevy, taxi, fiat1, fiat2];

    debugger;
    console.log(findCarInLot(chevy));
    console.log(findCarInLot(taxi));
    console.log(findCarInLot(fiat1));
    console.log(findCarInLot(fiat2));


var input = "jenny@wickedlysmart.com";
for(var i = 0; i < input.length; i++) {
if (input.charAt(i) === "@") {
console.log("There's an @ sign at index " + i);
}

}
