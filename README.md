# SCN
Sistema de Control de Negocio

# Controles

Estándar para nombres de controles
https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-basic-6/aa263493(v=vs.60)

Para los que no aparezcan. Utilizar:
GroupBox = gbx

# Variables

Estándar para nombres de variables y objetos
Si es privada empieza con _

El nombre de una variable privada tipo byte, sería un _ seguida
de la primera letra del tipo de dato, luego un nombre que sea
descriptivo y utilizar camelCase. Ejemplo:

private byte _bContador;

Es posible utilizar variables simples en ciclos, como en el caso del for.
Ejemplo:

for (int i = 0; i<length; i++)
{

}

# Estructura

Los corchetes van en línea independientes. Ejemplo:

if (true)
{

}

Cada línea debe de tener entre 60 y 80 caracteres como máximo.