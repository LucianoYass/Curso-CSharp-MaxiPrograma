namespace ejerciciosCiclosCombinados;
class Program
{
    static void Main(string[] args)
    {
        // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            // int n, con, conPrimos = 0;
            
            // for (int i = 0; i < 10; i++) {
                // Console.WriteLine("Ingrese un numero.");
                // n = int.Parse(Console.ReadLine());
                // con = 0;
                // for (int x = 1; x <= n; x++) {
                    // if (n % x == 0) {
                        // con++;
                    // };
                // };

                // if (con == 2) {
                    // conPrimos++;
                // };
            // };

            // Console.WriteLine("Hay "+conPrimos+" numeros primos.");

        // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
        // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        // Console.WriteLine("Ingrese un num");
        // var grupoImparesMaximo = 0;
        // var porcentajeMaximo = -1;
        // var conOrdenados = 0;
        // for (int i=0; i < 5; i++) {
            // var conNumeros = 0;
            // var conImpares = 0;
            // var banderaOrdenados = true;
            // var min = int.Parse(Console.ReadLine());
            // var n = min;
            // while (n != 0) {
                // conNumeros++;
                // if (n < min){
                    // banderaOrdenados = false;
                // }
                // if (n % 2 != 0) {
                    // conImpares++;
                // };
                // n = int.Parse(Console.ReadLine());
            // };
            // var porcentajeImpares = conImpares * 100 / conNumeros;
            // if (porcentajeImpares > porcentajeMaximo) {
                // porcentajeMaximo = porcentajeImpares;
                // grupoImparesMaximo = i + 1;
            // };
            // if (banderaOrdenados) {
                // conOrdenados++;
            // };
        // };
        // Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);
        // Console.WriteLine("La cantidad de grupos con numeros ordenados es: " + conOrdenados);

        // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

        // int n, con, numGrupo = 0;
        
        // Console.WriteLine("Ingrese un num");
        // n = int.Parse(Console.ReadLine());
        // while (n >= 0) {
            // numGrupo++;      
            // con = 0;
            // n = int.Parse(Console.ReadLine());
            // while (n > 0) {
                // con++;
                // n = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("La cantidad del grupo "+ numGrupo + " es "+con);
        // };

        // 4. Se dispone de una lista de 10 grupos de números enteros separados entre ellos por ceros. Se pide determinar e informar: 
        //a. El número de grupo con mayor porcentaje de números impares positivos respecto al total de números que forman el grupo. 
        //b. Para cada grupo, el último número primo y en qué orden apareció en ese grupo. Si en un grupo no hubiera números primos, informarlo con un cartel aclaratorio. 
        //c. Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        // int n, cTotal, cImpar, maxPorcentaje = 0, grupoMax = 0, orden, contadorPrimos, primo, posicionPrimo, mayor, bandera, cantidadOrdenada;

        // cantidadOrdenada = 0;
        // Console.WriteLine("Ingrese un num");

        // for (int i=0; i < 10; i++) {
            // cTotal = 0;
            // cImpar = 0;
            // orden = 0;
            // primo = 0;
            // posicionPrimo = 0;
            // mayor = int.MaxValue;
            // bandera = 0;
            // n = int.Parse(Console.ReadLine());
            // while (n != 0) {
                // cTotal++;
                // orden++;
                // contadorPrimos = 0;

                // if (n%2 != 0 && n > 0) {
                    // cImpar++;
                // }

                // for (int x = 1; x <= n; x++) {
                    // if (n % x == 0) {
                        // contadorPrimos++;
                    // }
                // }

                // if (contadorPrimos == 2) {
                    // primo = n;
                    // posicionPrimo = orden;
                // }

                // if (n < mayor) {
                    // mayor = n;
                // } else {
                    // bandera = 1;
                // }
                // n = int.Parse(Console.ReadLine());
            // }
            // int porcentaje = cImpar * 100 / cTotal;

            // if (porcentaje > maxPorcentaje) {
                // maxPorcentaje = porcentaje;
                // grupoMax = i+1;
            // }

            // if (primo != 0) {
                // Console.WriteLine("Grupo "+(i+1)+": Ultimo primo: "+primo+" Posicion: "+posicionPrimo);
            // } else {
                // Console.WriteLine("Grupo "+(i+1)+": No hay num primos");
            // }

            // if (bandera == 0) {
                // cantidadOrdenada++;
            // }
            
        // }
        // Console.WriteLine("Grupo con mayor porcentaje de impares positivos: "+grupoMax);
        // Console.WriteLine("Cantidad de grupos ordenados de mayor a menor: "+cantidadOrdenada);
        
        // 5. Una compañía de electricidad necesita calcular anualmente el consumo que ha registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos. Para ello tiene un lote de registros por cada uno de los usuarios con los siguientes datos:
                // • Zona (numérico entero).
                // • Número de cliente (número de cuatro dígitos no correlativos).
                // • Cantidad de kilovatios consumidos en el periodo.
        // El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro con zona igual a cero. Se pide generar un listado con el siguiente formato:
                // Zona: XX
                // Cantidad de usuarios de la zona: XX
                // Total facturado en la zona: XX
                // Zona: XX
                // Cantidad de usuarios de la zona: XX
                // Total facturado en la zona: XX
        // El precio es escalonado según la siguiente escala:
                // • $ 0.10 por kv por los primeros 100 kv de consumo.
                // • $ 0.12 por kv por el consumo de 101 a 200 kvs.
                // • $ 0.15 por kv por el consumo de 201 kvs en adelante.

                // int zona, numeroCliente, kilovatios, zonaActual, contadorUsuario, monto, montoTotal;
                // Console.WriteLine("Ingrese numero de zona:");
                // zona = int.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese numero de cliente:");
                // numeroCliente = int.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese cantidad de kilovatios:");
                // kilovatios = int.Parse(Console.ReadLine());

                // while (zona != 0) {
                    // zonaActual = zona;
                    // contadorUsuario = 0;
                    // montoTotal = 0;

                    // while (zona == zonaActual) {
                        // contadorUsuario++;
                        // if (kilovatios > 200) {
                            // monto = (int)(0.15 * kilovatios);
                        // } else if (kilovatios > 100) {
                            // monto = (int)(0.12 * kilovatios);
                        // } else {
                            // monto = (int)(0.10 * kilovatios);
                        // }
                        // montoTotal += monto;

                        // Console.WriteLine("Ingrese numero de zona:");
                        // zona = int.Parse(Console.ReadLine());
                        // Console.WriteLine("Ingrese numero de cliente:");
                        // numeroCliente = int.Parse(Console.ReadLine());
                        // Console.WriteLine("Ingrese cantidad de kilovatios:");
                        // kilovatios = int.Parse(Console.ReadLine());
                    // }
                    // Console.WriteLine("Zona: " + zonaActual);
                    // Console.WriteLine("Cantidad de usuarios de la zona: " + contadorUsuario);
                    // Console.WriteLine("Total facturado en la zona: " + montoTotal);
                // }

        // 6. Hacer un programa para ingresar los valores de los pesos de distintas encomiendas que se deben enviar a distintos clientes y que finaliza cuando se ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que pueden transportar hasta 200 kilos en total.
        // Por ejemplo:
        // 10, 20, 140, 70, 100, 40, 10, 50, 80, 90, 30, 40, 50, -10.
        //   Camión 1.  Camión 2   Camión 3        Camión 4  Camión 5
        // Se pide determinar e informar:
        // a. El número de camión y peso total de encomiendas (Camión 1: 170kg, Camión 2: 170kg, etc.).
        // b. El número de camión que transporta mayor cantidad de encomiendas (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
        // c. La cantidad de camiones que se terminaron cargando.
        
        // int p, pesoCamion, camion, encomiendas, maximoEncomiendas, camionMax;

        // camionMax = 0;
        // maximoEncomiendas = 0;
        // camion = 0;
        // Console.WriteLine("Ingrese el peso:");
        // p = int.Parse(Console.ReadLine());
        // while (p >= 0) {
            // encomiendas = 0;
            // pesoCamion = 0;
            // camion++;
            // p = int.Parse(Console.ReadLine());
            // while (p + pesoCamion <= 200) {
                // pesoCamion+=p;
                // encomiendas++;
            // }
            // Console.WriteLine("Camion: "+camion+", Peso de encomienda: "+pesoCamion);

            // if (encomiendas > maximoEncomiendas) {
                // maximoEncomiendas = encomiendas;
                // camionMax = camion;
            // }
        // }
        // Console.WriteLine("Camion: "+camionMax+" su cantidad de encomiendas: "+maximoEncomiendas+". Camiones cargados: "+camion);

        // 7. Una compañía de turismo aventura registró los paquetes vendidos durante la última temporada vacacional. Para cada venta se ingresó:
        // • Número de paquete (4 dígitos no correlativos).
        // • Cantidad de personas incluidas.
        // • Precio por persona.
        // • Horas totales de actividades.
        // • Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta. “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente).
        // El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con número de paquete cero. En el lote no se ingresan registros cuyo tipo de aventura no se haya vendido.
        // A partir de dichos datos, se solicita informar:
        // a. La cantidad de paquetes vendidos de cada tipo de aventura..
        // b. La cantidad total de personas que disfrutaron de las aventuras durante la temporada.
        // c. El total recaudado por cada venta.
        // d. La venta con mayor importe de cada tipo de aventura.
        // e. El paquete con menos horas incurridlas y en qué tipo de actividad fue.

        // int numeroPaquete, cantidadPersonas, precioPersona, horasActividad, tipoAventura, tipoAventuraActual, contadorPa = 0, acuPb = 0, precioVenta, max, min, tipoActividadMin;

        // Console.WriteLine("Ingrese el numero de paquete");
        // numeroPaquete = int.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese la cantidad de personas");
        // cantidadPersonas = int.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese el precio por persona");
        // precioPersona = int.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese las horas de la actividad");
        // horasActividad = int.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese el tipo de aventura");
        // tipoAventura = int.Parse(Console.ReadLine());

        // min = horasActividad;
        // tipoActividadMin = tipoAventura;

        // while (numeroPaquete != 0) {
            // tipoAventuraActual = tipoAventura;
            // contadorPa = 0;
            // max = 0;
            // while (tipoAventura == tipoAventuraActual) {
                // contadorPa++;
                // acuPb+=cantidadPersonas;
                // precioVenta = cantidadPersonas * precioPersona;
                // // Console.WriteLine("El total recaudado por cada venta es: "+precioVenta);

                // if (precioVenta > max) {
                    // max = precioVenta;
                // }

                // if (horasActividad < min) {
                    // min = horasActividad;
                    // tipoActividadMin = tipoAventura;
                // }

                // Console.WriteLine("Ingrese el numero de paquete");
                // numeroPaquete = int.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese la cantidad de personas");
                // cantidadPersonas = int.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese el precio por persona");
                // precioPersona = int.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese las horas de la actividad");
                // horasActividad = int.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese el tipo de aventura");
                // tipoAventura = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine(contadorPa);
            // Console.WriteLine(max);
        // }
        // Console.WriteLine(acuPb);
        // Console.WriteLine(min + tipoActividadMin);

        // 8. Una empresa registró las compras realizadas a sus distintos proveedores durante
        // todo el año anterior. Para cada compra se registraron los siguientes datos:
        // • Número de proveedor (número de cuatro cifras no correlativo).
        // • Día (1 a 31).
        // • Mes (1 a 12).
        // • Tipo de Factura (Responsable inscripto: "A",Consumidor Final: "B", o
        // Monotributo: "C").
        // • Número de Producto (número no correlativo).
        // • Cantidad comprada.
        // • Precio unitario del producto.
        // Este lote finaliza con un registro con número de proveedor igual a 0.
        // Los registros están agrupados por número de proveedor. En el lote anterior no
        // aparecen
        // registros de los proveedores a los que que no se les hayan realizado compras.
        // Se pide determinar e informar:
        // a. El monto máximo registrado en una sola compra por cada proveedor y el
        // número de proveedor al que se le compró.
        // b. La inversión total de todo el año discriminada por tipo de factura.
        // c. La compra con menor monto registrada durante el mes de Agosto junto al
        // número de producto comprado.
        // d. La cantidad de compras que se realizaron a cada proveedor.
        // e. El número de producto con mayor cantidad comprada en una sola compra y
        // en qué proveedor se compró.

        int numeroProveedor, dia, mes, numeroProducto, cantidad, precioUnitario, numeroProveedorActual, monto, acuA = 0, acuB = 0, acuC = 0, max = 0, bandera, min = 0, productoMin = 0, contadorCompra, prodMax = 0, numeroProveedorMax = 0;
        char tipoFactura;
        bandera = 0;

        Console.WriteLine("Ingrese numero de proveedor");
        numeroProveedor = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese dia");
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese mes");
        mes = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese tipo de factura");
        tipoFactura = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese numero de producto");
        numeroProducto = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cantidad");
        cantidad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese precio unitario");
        precioUnitario = int.Parse(Console.ReadLine());
        
        while (numeroProveedor != 0) {
            numeroProveedorActual = numeroProveedor;
            max = 0;
            contadorCompra = 0;
            while (numeroProveedor == numeroProveedorActual) {
                monto = cantidad * precioUnitario;
                if (monto > max) {
                    max = monto;
                }

                switch (tipoFactura) {
                    case 'a':
                        acuA+=monto;
                    break;
                    case 'b':
                        acuB+=monto;
                    break;
                    case 'c':
                        acuC+=monto;
                    break;
                }

                contadorCompra++;

                min = monto;

                if (mes == 8) {
                    if (bandera == 0) {
                        min = monto;
                        productoMin = numeroProducto;
                        bandera = 1;
                    } else if (monto < min) {
                        min = monto;
                        productoMin = numeroProducto;
                    }
                }

                if (cantidad > max) {
                    max = cantidad;
                    prodMax = numeroProducto;
                    numeroProveedorMax = numeroProveedor;
                }

                Console.WriteLine("Ingrese numero de proveedor");
                numeroProveedor = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese dia");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese mes");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tipo de factura");
                tipoFactura = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese numero de producto");
                numeroProducto = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio unitario");
                precioUnitario = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numero proveedor actual: "+numeroProveedorActual+" monto maximo: "+max);
            Console.WriteLine("El numero de compras: "+contadorCompra);
        }

        Console.WriteLine("La inversion total segun factura: "+acuA+", "+acuB+", "+acuC);
        Console.WriteLine("La menor compra: "+min+" el producto"+productoMin);
        Console.WriteLine("Producto: "+prodMax+", compras: "+max+" numero de proveedor: "+numeroProveedorMax);
        }
    }
