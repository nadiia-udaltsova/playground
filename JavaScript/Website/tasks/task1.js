let i = 0;
while (i < 3) {
    alert (i);
    i++;
}

let r = 0;
do {
  alert( r );
  i++;
} while (r < 3);


for (let z = 0; z < 10; z++){
    if (z % 2 == 0) continue; 
        alert (z);
    
}

let insertNumber;
do {
    insertNumber = prompt ("Введите число > 100", 0);
} while (insertNumber <= 100 || null)

let user = {
  name: "John",
  age: 30,
  "likes birds": true
};
alert (user.name);
alert (user.age);
alert (user ["likes birds"]);



function makeUser (name, age){
  return {
    name: name,
    age: age,
  };
}
let newUser = makeUser ("Ruslan", 45);
alert (newUser.name);

let usersite = {
  name: "Kirill",
  age: 29, 
  isAdmin: true,
};
for (key in usersite) {
  alert (key);
  alert (usersite[key]);
}

let usersite = {
  name: "John",
  surname: "Smith",
};
usersite.name = "Pete";
delete usersite.name;



let salaries = {
  John = 100,
  Ann = 130,
  Pete = 200,
};

let sum = 0;
for (key in salaries) {
  sum += salaries[key];
}
alert (sum);




function multiplyNumeric(obj) {
  for (key in obj) {
    if (typeof obj[key] == "number") {
      obj[key] *=2;
    }
  }
}