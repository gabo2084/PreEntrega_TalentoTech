'''
    Requerimientos:

    Ingreso de datos de productos: El sistema debe permitir ingresar datos básicos de los productos: nombre, categoría, y precio (sin centavos). 
    Estos datos deben almacenarse en una lista, donde cada producto sea representado/a como una sublista de tres elementos (nombre, categoría, y precio).

    Visualización de productos registrados: El programa debe incluir una funcionalidad para mostrar en pantalla todos los productos ingresados. 
    La información debe presentarse de manera ordenada y legible, con cada producto numerado.

    Búsqueda de productos: El sistema debe permitir buscar productos por su nombre. Si encuentra coincidencias, debe mostrar la información completa de los productos que coincidan. 
    Si no hay coincidencias, debe informar que no se encontraron resultados.

    Eliminación de productos: El sistema debe permitir eliminar un producto de la lista, identificándolo por su posición (número) en la lista.

    Usar listas para almacenar y gestionar los datos. 

    Incorporar bucles while y for según corresponda. 

    Validar entradas del usuario o usuaria, asegurándote de que no se ingresen datos vacíos o incorrectos.

    Utilizar condicionales para gestionar las opciones del menú y las validaciones necesarias.

    Presentar un menú que permita elegir entre las funcionalidades disponibles: agregar productos, visualizar productos, buscar productos y eliminar productos.

    El programa debe continuar funcionando hasta que se elija una opción para salir.

    #################################################

    Sistema de gestión básica de productos

    #################################################

        1. Agregar producto
        2. Mostrar productos
        3. Buscar producto
        4. Eliminar producto
        5. Salir
    
    #################################################
'''


productos = [
    ["Manzana", "Frutas", 2000],
    ["Leche", "Lacteos", 3000],
    ["Pan", "Panaderia", 1500],
    ["Carne", "Carniceria", 14000]
]

eleccion = ''

while eleccion != '5':

    print('\n====================================================================')
    print('============== Sistema de Gestion Basica de Productos ==============')
    print('====================================================================')

    print('''
    1. Agregar producto
    2. Mostrar productos
    3. Buscar producto
    4. Eliminar producto
    5. Salir
    ''')

    eleccion = input('Ingrese una opcion del menu(1/2/3/4/5): ')

    match eleccion:

        case '1':
            print('\n====================================================================')
            print('========================== Nuevo Producto ==========================')
            print('====================================================================')

            nombre_producto = ''
            categoria_producto = ''
            precio_producto = ''

            nro_validacion = 0

            while nro_validacion != 1:

                nombre_producto = input('\nNombre: ').strip().title()

                if nombre_producto == '' or nombre_producto.isnumeric():

                    print('Nombre invalido. Debe agregar una palabra y que no sea solo numeros.')
                    continue

                nro_validacion += 1 
                

            while nro_validacion != 2:

                categoria_producto = input('\nCategoria: ').strip().title()
                               
                if categoria_producto == '' or categoria_producto.isnumeric():

                    print('Categoria invalida. Debe agregar una palabra y que no sea solo numeros.')
                    continue

                nro_validacion += 1 

            while nro_validacion != 3:

                precio_producto = input('\nPrecio: $ ').strip()

                if precio_producto == '' or not precio_producto.isnumeric():

                    print('Precio invalido. Debe agregar un numero.')
                    continue

                nro_validacion += 1                                

            nuevo_producto = [nombre_producto, categoria_producto, precio_producto]
            productos.append(nuevo_producto)
            print('\nProducto agregado correctamente.')                
                

        case '2':

            print('\n====================================================================')
            print('======================= Listado de Productos =======================')
            print('====================================================================')
        
            for producto in productos:

                print(f'\n- Nombre: {producto[0]} | Categoria: {producto[1]} | Precio: $ {producto[2]}')

                        
        case '3':

            validacion = False

            producto_buscado = ''

            while validacion == False:

                print('\n====================================================================')
                print('======================= Busqueda de Producto =======================')
                print('====================================================================')

                producto_buscado = input('\nIngrese el nombre del producto a buscar: ').strip().title()

                if producto_buscado == '' or producto_buscado.isnumeric():

                    print('\nError. Debe ingresar una palabra y que no sea solo numeros.')
                    continue

                validacion = True

            for producto in productos:
                if producto[0] == producto_buscado:
                    producto_buscado = [producto[0], producto[1], producto[2]]
                    break

            if type(producto_buscado) is list:
                print(f'\nProducto encontrado!')
                print(f'\n- Nombre: {producto_buscado[0]}')
                print(f'- Categoria: {producto_buscado[1]}')
                print(f'- Precio: $ {producto_buscado[2]}')
            else:
                print('\nProducto no encontrado')
            
        case '4':

            validacion = False

            cantidad_productos = len(productos)

            print(cantidad_productos)

            producto_eliminar = ''

            producto_eliminado = []

            while validacion == False:
            
                print('\n====================================================================')
                print('========================= Eliminar Producto ========================')
                print('====================================================================')

                producto_eliminar = input('\nIngrese la posicion del producto a eliminar: ').strip()

                if producto_eliminar == '' or not producto_eliminar.isnumeric():

                    print('\nError. Debe ingresar el numero de posicion del producto a eliminar.')
                    continue

                elif int(producto_eliminar) > cantidad_productos:

                    print('\nLa posicion del producto ingresado esta fuera del rango')

                    validacion = True

                else:

                    for producto in productos:
                        if productos.index(producto) + 1 == int(producto_eliminar):
                            producto_eliminado = productos.pop(int(producto_eliminar)-1)
                            print(f'\nProducto eliminado!')
                            print(f'\n- Nombre: {producto_eliminado[0]}')
                            print(f'- Categoria: {producto_eliminado[1]}')
                            print(f'- Precio: $ {producto_eliminado[2]}')
                            break
            
                    producto_eliminado.clear()

                    validacion = True
                    

        case '5':

            print('\nsaliendo del sistema ...\n')
        case _:

            print('\nIngrese una opcion valida')




 