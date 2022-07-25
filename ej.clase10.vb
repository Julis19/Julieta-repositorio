let nombre = "Programación" + " Fácil.";
let saludo = "Les doy la bienvenida a ";
let docente = " Profesora Mariana";
let fraseCompleta = saludo + nombre + docente;
console.log(fraseCompleta);


let frase = "JavaScript " + "es un lenguaje" + " esencial para crear" + " sitios web poderosos.";
console.log(frase);


let numeroString1 = "10 ";
let numeroString2 = " 20";
let numeroString3 = " 30";
let frase = ["camiones"," van por la ruta"," para llegar a destino el dia"];
let concatenaNumerosfrase = numeroString1+ frase[0] + frase[1] + numeroString2 + frase[2] + numeroString3;
console.log(concatenaNumerosfrase);


var age= prompt("Cual es tu edad:?");
var name= prompt("Introduce tu nombre");
console.log(name,age);


let edad;
        edad = prompt('introduce tu edad');
        let sexo;
        sexo = prompt('introduce sexo -hombre o mujer-');
        if (sexo === 'hombre' && edad>=18){
            alert('puedes ingresar, eres hombre mayor de 18 años');
        }
        else
            if (sexo === 'mujer' && edad>=20){
            alert('puedes ingresar, eres mujer mayor de 20 años');
         } 
         else {
            alert('No puedes ingresar');
        }

