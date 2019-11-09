console.log("Hello word!");


let guestList = "Guests:\n * John\n * Pete\n * Mary";
alert(guestList);

/*Напишите функцию ucFirst(str), возвращающую строку str с заглавным первым символом. Например:

ucFirst("вася") == "Вася";*/

//ucFirst("вася") =="Вася";
function ucFirst(str){
  if(!str) return str;
  return str[0].toUpperCase() + str.slice(1);

}
console.log(ucFirst("вася"));

function checkSpam(newstr){
  let lowerStr = newstr.toLowerCase();
  return lowerStr.includes('viagra') || lowerStr.includes('xxx');
}
console.log(checkSpam('buy ViAgRA now'));
console.log(checkSpam('free xxxxx'));
console.log(checkSpam("innocent rabbit"));

function truncate(str, maxlength) {
  return (str.length > maxlength) ?
    str.slice(0, maxlength - 1) + '…' : str;
}

function cutStr(happy, 4) {
  return (happy.length > 4) ?
  happy.slice(0, 4-1) + '…' : happy;
}