console.log("Hello word!");


let guestList = "Guests:\n * John\n * Pete\n * Mary";
alert(guestList);

/*Напишите функцию ucFirst(str), возвращающую строку str с заглавным первым символом. Например:

ucFirst("вася") == "Вася";*/
function ucFirst(str) {
    if (!str) return str;
  
    return str[0].toUpperCase() + str.slice(1);
  }
  
  alert( ucFirst("вася") );