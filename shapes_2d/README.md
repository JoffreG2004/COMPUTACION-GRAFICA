# Documentación del proyecto (sin cuadrado ni triángulo)

## 1) Cónicas (3)
### `FrmCirculo`
- **Entrada:** `TxtRadio` / `LblRadio`.
- **Cálculos:**
  - Perímetro = `2πr`
  - Área = `πr²`
- **Dibujo:** círculo en `x=700`, `y=150`, tamaño proporcional al radio, sin `scale`.

### `FrmOvalo`
- **Entrada:** `TxtRadio1` / `LblRadio1` (Tamaño).
- **Cálculos:** el tamaño controla alto y ancho con proporción fija (huevo).
- **Dibujo:** óvalo tipo “huevo” con dos arcos unidos, en `x=700`, `y=150`, sin `scale`.

### `FrmElipse`
- **Entradas:** `TxtRadio1` y `TxtRadio2`.
- **Cálculos:**
  - Área = `πab`
  - Perímetro aproximado
- **Dibujo:** elipse en `x=700`, `y=150`, sin `scale`.

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
