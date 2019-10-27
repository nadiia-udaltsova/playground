
------------------------------------------------------
null       - нет значения но оно было присвоено
undefined  - нет значения и оно не было присвоино


==   - нестрогое сравнение (1 == "1", null == undefined)
===  - строгое сравнение   (в дополниение к сравнению, еще сравниваются сами тыпы данных)
------------------------------------------------------
this - контекст



var man = {
	name: "jack",
	age: 24,
	sayHi: function(){
		console.log('Hi. My name is ' + this.name); //контекст это обект
	}
}

console.log(this); //контекст это window

когда функция создается, то к ней прикрепляется контекст
 - усли функция создана внутри обекта, то контекст это обект
 - если воздается просто функция, то контекст это обект окна браузера (Window)


обект.метод.apply(другой обект) - вызвать метод с подменненным контекстом
------------------------------------------------------

двойное равенство == сравнивает на равенство, а тройное === на идентичность

___________________________________________________ 
Числа

let billion = 1e9;  // 1 миллиард, буквально: 1 и 9 нулей
alert( 7.3e9 );  // 7.3 миллиардов (7,300,000,000)
let ms = 0.000001;
Записать микросекунду в укороченном виде нам поможет "e".

let ms = 1e-6; // шесть нулей, слева от 1
Метод num.toString(base) возвращает строковое представление числа num в системе счисления base.
base может варьироваться от 2 до 36 (по умолчанию 10).

В JavaScript есть несколько встроенных функций для работы с округлением:

Math.floor
Округление в меньшую сторону: 3.1 становится 3, а -1.1 — -2.
Math.ceil
Округление в большую сторону: 3.1 становится 4, а -1.1 — -1.
Math.round
Округление до ближайшего целого: 3.1 становится 3, 3.6 — 4, а -1.1 — -1.
Math.trunc (не поддерживается в Internet Explorer)
Производит удаление дробной части без округления: 3.1 становится 3, а -1.1 — -1.


Метод toFixed(n) округляет число до n знаков после запятой и возвращает строковое представление результата.


метод toFixed всегда возвращает строку. Это гарантирует, что результат будет с заданным количеством цифр в десятичной части. 

Чтобы писать большие числа:

Используйте краткую форму записи больших чисел – "e", с указанным количеством нулей. Например: 123e6 это 123 с 6-ю нулями.
Отрицательное число после "e" приводит к делению числа на 1 с указанным количеством нулей.
Для других систем счисления:

Можно записывать числа сразу в шестнадцатеричной (0x), восьмеричной (0o) и бинарной (0b) системах счисления
parseInt(str, base) преобразует строку в целое число в соответствии с указанной системой счисления: 2 ≤ base ≤ 36.
num.toString(base) представляет число в строковом виде в указанной системе счисления base.
Для преобразования значений типа 12pt и 100px в число:

Используйте parseInt/parseFloat для «мягкого» преобразования строки в число, данные функции по порядку считывают число из строки до тех пор пока не возникнет ошибка.

























