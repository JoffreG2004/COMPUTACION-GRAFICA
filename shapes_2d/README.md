# Documentación Técnica del Proyecto de Gráficos 2D

## Resumen Ejecutivo

Este proyecto implementa una aplicación gráfica en C# utilizando Windows Forms para visualizar y calcular propiedades geométricas de 12 figuras 2D diferentes. La aplicación incluye cónicas, cuadriláteros, polígonos regulares e irregulares. Cada formulario permite al usuario ingresar parámetros específicos, realiza cálculos matemáticos y visualiza la figura en tiempo real.

---

## 1. Figuras Cónicas (3)

### 1.1 Círculo (`FrmCirculo.cs`)

#### Desarrollo Técnico
- **Entrada:** Radio (`TxtRadio`)
- **Validación:** Verifica que el radio sea un número decimal positivo mayor a 0
- **Escala:** Factor de 10 píxeles por unidad (radio * 2 * 10 = diámetro en píxeles)

#### Implementación Técnica

**Cálculos:**
- Perímetro = 2πr
- Área = πr²

**Renderizado:**
- Posición: x=700, y=150
- Diámetro = radio × 20 píxeles
- Uso de `Graphics.FillEllipse()` y `Graphics.DrawEllipse()`
- Color: `GreenYellow` con transparencia (128 alpha)
- SmoothingMode: AntiAlias

#### Resultados
Los cálculos se muestran con 2 decimales de precisión. La visualización es proporcional al radio.

---

### 1.2 Óvalo (`FrmOvalo.cs`)

#### Desarrollo Técnico
- **Entrada:** Tamaño (`TxtRadio1`)
- **Proporciones:** Altura = tamaño × 20, Ancho = Altura × 0.75
- **Tipo:** Óvalo tipo "huevo" usando dos arcos unidos

#### Implementación Técnica

**Cálculos:**
- height = radio1 × 2 × 10
- width = height × 0.75
- Perímetro usando aproximación: π(3(a+b) - √((3a+b)(a+3b)))
- Área = π × a × b

**Código:** Usa `GraphicsPath` con dos `AddArc()` para crear la forma de huevo

**Resultados:**
Forma ovalada simétrica con color `IndianRed` (180 alpha).

---

### 1.3 Elipse (`FrmElipse.cs`)

#### Desarrollo Técnico
- **Entradas:** Dos radios (`TxtRadio1`, `TxtRadio2`)
- **Validación:** Ambos radios deben ser positivos
- **Escala:** radio × 2 × 10 para ancho y alto

#### Implementación Técnica

**Cálculos:**
- Perímetro (aproximación de Ramanujan): π(3(a+b) - √((3a+b)(a+3b)))
- Área = π × a × b

**Código:** `Graphics.FillEllipse()` con dimensiones independientes

**Resultados:**
Elipse con proporciones definidas por los dos radios. Color: `MediumPurple` (128 alpha).

---

## 2. Cuadriláteros (3)

### 2.1 Paralelogramo (`FrmParalelogramo.cs`)

#### Desarrollo Técnico
- **Entradas:** Ancho, Altura/Largo, Inclinación
- **Validación:** Todos los valores deben ser positivos
- **Construcción:** 4 puntos ordenados para crear el polígono inclinado

#### Implementación Técnica

**Cálculos:**
- lado = √(altura² + inclinación²)
- Perímetro = 2(ancho + lado)
- Área = ancho × altura

**Código:** `Graphics.FillPolygon()` con 4 vértices calculados por offset

**Resultados:**
Paralelogramo inclinado correctamente escalado. Color: `Goldenrod` (180 alpha).

---

### 2.2 Rombo (`FrmRombo.cs`)

#### Desarrollo Técnico
- **Entrada:** Lado (`TxtAncho`)
- **Nota:** Implementado como cuadrado perfecto
- **Escala:** lado × 10 píxeles

#### Implementación Técnica

**Cálculos:**
- Perímetro = 4a
- Área = a²

**Código:** `Graphics.FillRectangle()` con dimensiones iguales

**Resultados:**
Cuadrado perfecto. Color: `DodgerBlue` (180 alpha).

---

### 2.3 Cometa (`FrmCometa.cs`)

#### Desarrollo Técnico
- **Entradas:** Ancho (eje A), Largo (eje B)
- **Forma:** Cuadrilátero con vértices en extremos de diagonales perpendiculares

#### Implementación Técnica

**Cálculos:**
- lado = √((A/2)² + (B/2)²)
- Perímetro = 4 × lado
- Área = (A × B) / 2

**Código:** `Graphics.FillPolygon()` con 4 vértices centrados

**Resultados:**
Forma de cometa con diagonales perfectamente centradas. Color: `MediumPurple` (180 alpha).

---

## 3. Polígonos Regulares (1)

### 3.1 Polígonos Regulares (`FrmPoligonos.cs`)

#### Desarrollo Técnico
- **Entradas:** Lado, Número de lados (n ≥ 3)
- **Algoritmo:** Cálculo de vértices usando trigonometría circular
- **Centro:** (700, 150)
- **Ángulo inicial:** -90° para que el primer vértice apunte hacia arriba

#### Implementación Técnica

**Cálculos:**
- Perímetro = n × lado
- Área = (n × lado²) / (4 × tan(π/n))

**Código:** Bucle que calcula cada vértice usando ángulos equidistantes

**Resultados:**
Polígono regular perfecto con n lados. Color: `SandyBrown` (180 alpha).

---

## 4. Figuras Irregulares (3)

### 4.1 Estrella (`FrmEstrella.cs`)

#### Desarrollo Técnico
- **Entrada:** Tamaño
- **Puntos:** 10 vértices (5 puntas)
- **Radios:** Exterior = tamaño × 10, Interior = tamaño × 5

#### Implementación Técnica

**Cálculos:**
- Área: Fórmula del Shoelace (suma de productos cruzados)
- Perímetro: Suma de distancias entre vértices consecutivos

**Código:** 10 puntos alternando radios, ángulo de 36° entre cada punto

**Resultados:**
Estrella de 5 puntas simétrica. Color: `SkyBlue` (180 alpha).

---

### 4.2 Corazón (`FrmCorazon.cs`)

#### Desarrollo Técnico
- **Entrada:** Tamaño
- **Método:** Curva paramétrica (Alcides Ribeiro)
- **Puntos:** 360 (uno por grado)

#### Implementación Técnica

**Ecuaciones Paramétricas:**
- x = 16 × sin³(t)
- y = 13cos(t) - 5cos(2t) - 2cos(3t) - cos(4t)

**Cálculos (Aproximados):**
- Área ≈ πr² + 1.4r²
- Perímetro ≈ 2πr + 2√(r² + (1.4r)²)

**Código:** Loop de 0° a 360° generando puntos con transformaciones

**Resultados:**
Corazón suave y simétrico. Color: `Red` (200 alpha).

---

### 4.3 Luna Creciente (`FrmLunaCreciente.cs`)

#### Desarrollo Técnico
- **Entrada:** Tamaño
- **Método:** Diferencia de regiones (resta de círculos)
- **Radios:** Exterior = tamaño × 10, Interior = tamaño × 6

#### Implementación Técnica

**Cálculos:**
- Área = π(radio² - radioInterno²)
- Perímetro = 2πradio + 2πradioInterno

**Código:** Usa `GraphicsPath` y `Region` para operaciones booleanas

**Resultados:**
Luna creciente simétrica por sustracción de regiones. Color: `YellowGreen` (RGB 184,199,112).

---

## 5. Arquitectura General

Cada formulario hereda de `Form` y sigue un patrón consistente:
1. Validación de entrada con `TryParse()`
2. Cálculos matemáticos específicos
3. Visualización mediante evento `Paint`
4. Controles UI: Calcular, Resetear, Salir

---

## 6. Conclusión

El proyecto implementa 12 figuras geométricas con cálculos precisos y visualización de alta calidad usando técnicas avanzadas de GDI+.
