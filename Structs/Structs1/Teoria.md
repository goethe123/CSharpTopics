# 1 ¿Qué es un struct?
Un struct (estructura) es un tipo de valor en C# que se utiliza para agrupar datos relacionados en una sola unidad.
Similar a una clase, pero con diferencias importantes en memoria, comportamiento y uso.

# 2. Características clave
Tipo de valor: se almacena en la pila (stack) en lugar del montón (heap), lo que hace que sea más rápido para estructuras pequeñas.
No necesita instanciarse con new (aunque puedes hacerlo).
No admite herencia de clases, pero sí puede implementar interfaces.
Se copian por valor (al asignar un struct a otra variable, se crea una copia independiente).
Puede contener:
Campos
Propiedades
Métodos
Constructores (con limitaciones)


# 3. Diferencias entre struct y class
Característica	                     Struct (Value Type)	Class (Reference Type)

Almacenamiento	                     Pila (stack)	        Montón (heap)
Copia	                             Por valor (duplica)	Por referencia
Herencia	                         ❌ No	               ✅ Sí
Constructor por defecto         	 Implícito	            Implícito
Uso típico	                         Datos pequeños	        Objetos complejos


Podríamos decir que los structs son como la versión ligera de una clase, pensada para
casos muy concretos, no para reemplazarla.