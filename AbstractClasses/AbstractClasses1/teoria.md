# 1. Clases abstractas
Una clase abstracta es una clase que no se puede instanciar directamente.
Se utiliza como plantilla para que otras clases hereden de ella.
Puede contener:
Métodos abstractos (sin implementación).
Métodos concretos (con implementación normal).
Propiedades y campos.
Sirven para definir un contrato parcial y compartir código común entre las clases hijas.

# 2. Métodos abstractos
Son métodos declarados sin cuerpo en la clase abstracta.
Obligan a que todas las clases hijas concretas los implementen usando override.
Solo pueden existir dentro de clases abstractas.
No pueden ser private (ya que deben ser accesibles para las clases hijas). 

# En tu código:
Figura es la clase abstracta que define el contrato (Area() y Perimetro()).
Rectangulo y Circulo implementan estos métodos con override.
En Main, se crea una lista List<Figura> y se recorre de forma polimórfica, llamando a los métodos sin importar el tipo real del objeto.
Beneficio: si mañana agregas Triangulo, el resto del código no cambia, solo agregas la nueva clase.