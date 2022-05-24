String es un tipo por referencia

Secuencias de escape de cadena en C#
\ '- comilla simple (0x0027)
\ "- comillas dobles (0x0022)
\\ - barra invertida (0x005C)
\ 0 - nulo (0x0000)
\ a - alerta (0x0007)
\ b - retroceso (0x0008)
\ f - alimentación de formulario (0x000C)
\ n - nueva línea (0x000A)
\ r - retorno de carro (0x000D)
\ t - pestaña horizontal (0x0009)
\ v - pestaña vertical (0x000B)
\ u0000 - \ uFFFF - Carácter Unicode
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable)
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos)

"#" Los literales de cadena textual son más cómodos para cadenas de varias líneas, 
cadenas que contienen caracteres de barra diagonal inversa o comillas dobles incrustadas. 
Las cadenas textuales conservan nuevos caracteres de línea como parte del texto de cadena.

"$" Las cadenas interpoladas se identifican por el carácter especial $ e incluyen expresiones interpoladas entre llaves.
La interpolación de cadenas se usa para mejorar la legibilidad y el mantenimiento del código. 
Con la interpolación de cadenas obtenemos los mismos resultados que con el método String.Format, 
pero mejora la facilidad de uso y la claridad en línea.