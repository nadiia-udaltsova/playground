
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
