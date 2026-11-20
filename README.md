# Universidad Central del Este (UCE)
## Examen Práctico - Programación Básica

**Nombre:** Raydelin Alexander Mateo Lorenzo  
**Matrícula:** 2025-1401  
**Maestro:** Gamalier Reyes  
**Fecha:** 19/11/2026  

---

## Descripción del programa
Aplicación de escritorio en C# Windows Forms (`FrmPedidos`) para registrar pedidos de la cafetería "El Buen Sabor" y calcular el total a pagar con tamaño, porción extra, descuento, empaque e ITBIS.

## Datos de entrada
- Nombre del cliente (`txtCliente`), si es cliente frecuente (`chkFrecuente`) y fecha (`dtpFecha`).
- Nombre del producto (`txtProducto`), precio (`txtPrecio`), cantidad (`nudCantidad`), tamaño (`rbtNormal` o `rbtGrande`) y porción extra (`chkPorcionExtra`).
- Tipo de servicio (`rbtLocal` o `rbtLlevar`).

## Proceso
- **Al cargar (`Load`):** Se ponen los valores iniciales y los títulos de columnas en `lblEncabezado`.
- **Al agregar (`btnAgregar`):** Se suma RD$25 si es grande y RD$30 si lleva porción extra, se multiplica por la cantidad, se agrega la línea formateada a `lstPedido`, se suma al subtotal y se limpian los campos del producto.
- **Al calcular (`btnCalcular`):** Si hay productos, se calcula el 10% de descuento si es frecuente, RD$20 de empaque si es para llevar, la base imponible, el 18% de ITBIS y el total a pagar.
- **Limpiar (`btnLimpiar`):** Borra todo, pone el subtotal en 0 y coloca el cursor en `txtCliente`.
- **Salir (`btnSalir`):** Pide confirmación con un mensaje de Sí/No antes de cerrar.

## Salida
- Lista de productos agregados en `lstPedido`.
- Resultados en formato `RD$ 0.00` para subtotal, descuento, empaque, ITBIS y total a pagar.
- Mensajes de aviso o confirmación en pantalla.

<img width="1600" height="1200" alt="image" src="https://github.com/user-attachments/assets/af60ad8f-9e9a-4ce6-85ed-400cc50e7038" />


