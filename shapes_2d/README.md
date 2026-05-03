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

## 2) Cuadriláteros (3)
### `FrmParalelogramo`
- **Entradas:** `TxtAncho`, `TxtLargo` (altura), `TxtInclinacion`.
- **Cálculos:**
  - Área = `ancho * altura`
  - Perímetro = `2 * (ancho + lado)` con `lado = √(altura² + inclinación²)`
- **Dibujo:** paralelogramo en `x=700`, `y=150`, color amarillo oscuro.

### `FrmRombo`
- **Entrada:** `TxtAncho` (lado).
- **Cálculos:**
  - Perímetro = `4a`
  - Área = `a²`
- **Dibujo:** cuadrado (rombo) en `x=700`, `y=150`, color azul.

### `FrmCometa`
- **Entradas:** `TxtAncho` y `TxtLargo` (A y B).
- **Cálculos:**
  - Área = `(A * B) / 2`
  - Perímetro = `4 * √((A/2)² + (B/2)²)`
- **Dibujo:** cometa en `x=700`, `y=150`, color morado.

## 3) Polígonos Regulares (1 formulario)
### `FrmHexagono` (polígonos regulares)
- **Entradas:** `TxtAncho` (lado) y `TxtNumLados` (n ≥ 3).
- **Cálculos:**
  - Perímetro = `n * lado`
  - Área = `(n * lado²) / (4 * tan(π/n))`
- **Dibujo:** polígono regular con `n` lados, en `x=700`, `y=150`, sin `scale`.

## 4) Figuras Irregulares (3)
### `FrmEstrella`
- **Entrada:** `TxtTamaño` / `LblTamaño`.
- **Cálculos:** perímetro y área aproximados a partir de los 10 puntos de la estrella.
- **Dibujo:** estrella celeste en `x=700`, `y=150`.

### `FrmCorazon`
- **Entrada:** `TxtTamaño` / `LblTamaño`.
- **Cálculos:** aproximados.
- **Dibujo:** corazón con curva paramétrica, color rojo, en `x=700`, `y=150`.

### `FrmLunaCreciente`
- **Entrada:** `TxtTamaño` / `LblTamaño`.
- **Cálculos:** diferencia de áreas entre círculos.
- **Dibujo:** luna creciente amarilla oscura con recorte, en `x=700`, `y=150`.
