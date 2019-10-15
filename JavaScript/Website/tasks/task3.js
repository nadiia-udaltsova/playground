let userName = prompt ("Введите имя");
let isTeaWanted = confirm ("Вы хотите чаю?");
alert ("Посетитель: " + userName); //Алиса
alert ("Чай: " + isTeaWanted)// true

let value = true;
alert (typeof value);//boolean
value = String(value);
alert (typeof value); //string

//Создайте страницу, которая спрашивает имя 
//у пользователя и выводит его.
newFunction();

function newFunction() {
    let name = prompt("Введите Ваше имя?", "");
    alert(name);
}

let year = prompt ("В каком году появилась спецификация ECMAScript-2015?", " ");
if (year < 2015) {
    alert("Это слишком рано...");
} else if (year > 2015) {
    alert ("Это слишком поздно...");
}
else {
    alert ("Верно! Вы угадали!");
}

/*Используя конструкцию if..else, напишите код, который будет спрашивать:
 „Какое «официальное» название JavaScript?“

Если пользователь вводит «ECMAScript», 
то показать: «Верно!», в противном случае – отобразить:
 «Не знаете? ECMAScript!»*/

 let questionJS = prompt ("Какое `официальное` название JavaScript?", " ");
 if (questionJS == ECMAScript) {
     alert ("ВЕРНО!");
 } else {
     alert ("Не знаете? ECMAScript!");
 }

 /*Используя конструкцию if..else, напишите код, который получает число через prompt,
  а затем выводит в alert:

1, если значение больше нуля,
-1, если значение меньше нуля,
0, если значение равно нулю.
Предполагается, что пользователь вводит только числа.*/

let sayNumber = prompt ("Введите любое число", " ");
if (sayNumber > 0) {
    alert ("1");
} else if (sayNumber < 0) {
    alert ("-1");
} else {
    alert ("0");
}



let login = prompt ("Введите логин", " ");
if (login == "Админ"){

let parol =  prompt ("Введите пароль", " ");
if (parol== "Я Главный"){
    alert ("Здравствуйте");
} else if (parol == " " || null){
    alert ("Отменено");
} else ("Неверный пароль")

}

 else if (login == " "|| login == null){
    alert ("Отменено");
 } else {
     alert ("Я Вас не знаю");
 }



