--YASSER MERCADO--01--
select PEL.nombre_pelicula PELICULAS, CONVERT(varchar, ENT.fecha_entrada,3) FECHA, CAST(DET.descuento as varchar) + '%' DESCUENTO,
	   COM.monto MONTO, COM.cantidad CANTIDAD
from DETALLES_COMPROBANTES DDC join COMPROBANTES COM on DDC.id_detalle_comprobante = COM.id_detalle_comprobante
						   join ENTRADAS ENT on COM.id_entrada = ENT.id_entrada
						   join DESCUENTOS DET on DDC.id_descuento = DET.id_descuento
						   join FUNCIONES FUN on FUN.id_funcion = ENT.id_entrada
						   join PELICULAS PEL on PEL.id_pelicula = PEL.id_pelicula
where DDC.id_forma_pago in (select FDP.id_forma_pago
						   from FORMAS_PAGOS FDP
						   where FDP.id_forma_pago = DDC.id_forma_pago and
						   FDP.forma_pago like '%tarjeta%')
	  and datediff(MONTH, fecha_entrada, GETDATE()) = 2
	  and DET.descuento > 20
order by 3

--YASSER MERCADO--02--
select BUT.fila + CAST(BUT.numero as varchar) BUTACA, CLI.nombre_cliente + ' ' + CLI.apellido_cliente CLINTE,
	   COUNT(fecha_entrada) ASISTENCIAS
from BUTACAS BUT join DETALLES_SALAS DDS on BUT.id_butaca=DDS.id_butaca
				 join ENTRADAS ENT on DDS.id_detalle_sala=ENT.id_detalle_sala
				 join CLIENTES CLI on CLI.id_cliente=ENT.id_cliente
				 join FUNCIONES FUN on FUN.id_funcion=ENT.id_funcion
				 join PELICULAS PEL on PEL.id_pelicula=FUN.id_pelicula
where exists (select CLA.clasificacion
			 from CLASIFICACIONES CLA
			 where CLA.clasificacion = 'G')
group by BUT.fila + CAST(BUT.numero as varchar), CLI.nombre_cliente + ' ' + CLI.apellido_cliente
having COUNT(fecha_entrada)>3
order by 3 desc

