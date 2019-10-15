
/*Объявите две переменные: admin и name.
Запишите строку "Джон" в переменную name.
Скопируйте значение из переменной name в admin.
Выведите на экран значение admin, 
используя функцию alert (должна показать «Джон»).*/

let admin;
let name = "Джон";
admin = name;
alert (admin);

/*Создайте переменную для названия нашей планеты. 
Как бы вы её назвали?
Создайте переменную для хранения имени текущего посетителя 
сайта. Как бы вы назвали такую переменную?*/
let planetEarth;
let currentSiteVisitor;

let userName = "Вася";
function showMessage (){
    let message = "Привет, " + userName;
    alert (message); 
}
showMessage();

/* Напишите функцию min(a,b),
 которая возвращает меньшее из чисел a и b.*/

 min(2, 5) == 2
min(3, -1) == -1
min(1, 1) == 1

function min (a,b){
    if (a > b) {
    return b;
} else {
    return a;
}
}

function multi (x = 9, y = 8){
    return x * y;
}
console.log (multi (4,5));
console.log (multi (20,5));
console.log (multi (20));