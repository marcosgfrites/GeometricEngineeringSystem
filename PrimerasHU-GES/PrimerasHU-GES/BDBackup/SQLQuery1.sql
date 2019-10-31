USE ges_v01
GO

SELECT * FROM usuarios

INSERT INTO usuarios
VALUES (1,1,'Mauro Ciparelli','maucip',Null),
(1,1,'Marcos Frites','marfri',Null),
(1,1,'Pablo Roqu�','pabroq',Null)

INSERT INTO usuarios
VALUES (1,2,'Juan P�rez','juaper',Null)


SELECT * FROM tiposUsuario

INSERT INTO tiposUsuario
VALUES ('Administrador'),('Encargado DE&MS'),('Responsable Analista')

SELECT * FROM estados

INSERT INTO estados
VALUES ('Habilitado'),('Deshabilitado')

SELECT * FROM imagenes

SELECT * FROM compiladores

SELECT * FROM establecimientos
insert into establecimientos values ('FAASA','Fiat Chrysler C�doba')

SELECT * FROM documentosDmo

SELECT * FROM controlPlan

SELECT * FROM versionesModelo
SELECT * FROM tiposVehiculo

SELECT * FROM controlPlan

SELECT * FROM detallesControlPlan
TRUNCATE TABLE detallesControlPlan
DELETE FROM detallesControlPlan

SELECT * FROM tiposPunto
SELECT * FROM clasificacionesPunto
INSERT INTO tiposPunto VALUES ('R','P','Riferimento')


TRUNCATE TABLE controlPlan


/**RECUPERA LA RELACION ENTRE LAS TABLAS tiposPunto y clasificacionesPunto**/
ALTER TABLE tiposPunto WITH NOCHECK
ADD FOREIGN KEY (codClasifPto)
REFERENCES clasificacionesPunto(codClasifPto)

/**RECONSTRUYE LA TABLA PERMITIENDO LA REPETICION DE PK DUPLICADOS**/
ALTER TABLE puntosMedidosD REBUILD WITH (IGNORE_DUP_KEY = ON)

/**RESETEA EL IDENTITY DE LA TABLA**/
DBCC CHECKIDENT ('nombreTabla',RESEED,0)

ALTER TABLE puntosMedidosD
ADD FOREIGN KEY (codDmo, codMedicion) REFERENCES detallesDocumentoDmo (codDmo, codMedicion),
PRIMARY KEY (codDmo,codMedicion, idDistanciaD)

ALTER TABLE muestras
ADD FOREIGN KEY (pun3_codDmo, pun3_codMedicion, codMediD) REFERENCES puntosMedidosD (codDmo, codMedicion, codMediD)

/**PROBANDO CONSULTAS**/
SELECT codCPlan FROM controlPlan WHERE codPrograma='L359016215PS300MM'

SELECT * FROM establecimientos
INSERT INTO establecimientos VALUES ('FAASA','Fiat Auto Argentina S.A.')

SELECT * FROM tiposVehiculo

SELECT codTipoV FROM tiposVehiculo WHERE codTipoV='S'

SELECT codOper FROM operariosMaquina WHERE nomOper='MATIAS TORRE'

DELETE FROM detallesControlPlan

SELECT codRegla FROM reglasMedicion WHERE descRegla='RETICULO'

SELECT * FROM seccionesVehiculo

SELECT cp.codCPlan AS 'Control Plan',cp.codPrograma AS 'Programa',sv.descSeccion AS 'Secci�n',dd.codDmo AS 'Documento Dmo',dd.fechaDmo AS 'Fecha del Dmo',dd.hora AS 'Hora del Dmo'
FROM controlPlan AS cp,seccionesVehiculo AS sv,documentosDmo AS dd
WHERE cp.codCPlan=dd.codCPlan AND cp.codSeccion=sv.codSeccion
ORDER BY dd.fechaDmo DESC,dd.hora DESC

/****/
/****/
/****/
/****/
/****/
/****/
/****/
/****/

/** QUERYS SOBRE TABLAS PARA EL FINAL **/

/** MANEJO DE TABLA: TIPOSVEHICULO **/
SELECT * FROM tiposVehiculo
DELETE FROM tiposVehiculo WHERE descTipoV = 'Prueba 1'

/** MANEJO DE TABLA: VERSIONESMODELO **/
SELECT * FROM versionesModelo
DELETE FROM versionesModelo WHERE codVersion = '8P'

/** MANEJO DE TABLA: MODELOSVEHICULO **/
SELECT * FROM modelosVehiculo
DELETE FROM modelosVehiculo WHERE codVersion = '8P'

/** MANEJO DE TABLA: SECCIONESVEHICULO **/
SELECT * FROM seccionesVehiculo
DELETE FROM seccionesVehiculo
DBCC CHECKIDENT ('seccionesVehiculo',RESEED,0)
INSERT INTO seccionesVehiculo (codProyecto,descSeccion,verSeccion) VALUES (359,'CS SCOCCA',4),
(359,'VANO PLANCIA',4), (359,'VANO BAULE',4), (359,'VANO FONDELO FANALLE SX',4), (359,'VANO FONDELO FANALLE DX',4),
(359,'VANO SUSPENSION POSTERIOR',4), (359,'VANO SUSPENSION ANTERIOR',4), (359,'VANO PTA POST SX',4), (359,'VANO PTA POST DX',4),
(359,'VANO PTA ANT SX',4), (359,'VANO PTA ANT DX',4), (359,'VANO PARABREZZA',4), (359,'CS FIANCATA SX',4), (359,'CS FIANCATA DX',4),
(359,'VANO FRONTAL',4), (359,'VANO SEDILE ANTERIOR SX',4), (359,'VANO SEDILE ANTERIOR DX',4), (359,'AUTOTELAIO',4), (359,'CS BAULE',4),
(359,'CS COFANO',4), (359,'CS PUERTA POSTERIOR SX',4), (359,'CS PUERTA POSTERIOR DX',4), (359,'CS PUERTA ANTERIOR SX',4), (359,'CS PUERTA ANTERIOR DX',4)

/** MANEJO DE TABLA: ENTIDADES **/
SELECT * FROM entidades

SELECT * FROM tiposPunto

/** MANEJO DE TABLA: IMAGENES **/
SELECT * FROM imagenes
DELETE FROM imagenes
DBCC CHECKIDENT ('imagenes',RESEED,0)

/** MANEJO DE TABLA: CONTROLPLAN **/
SELECT * FROM controlPlan
DELETE FROM controlPlan
DBCC CHECKIDENT ('controlPlan',RESEED,0)

/** MANEJO DE TABLA: DETALLESCONTROLPLAN **/
SELECT * FROM detallesControlPlan
DELETE FROM detallesControlPlan
DBCC CHECKIDENT ('detallesControlPlan',RESEED,0)

/** MANEJO DE TABLA: DOCUMENTOSDMO **/
SELECT * FROM documentosDmo
DELETE FROM documentosDmo

/** MANEJO DE TABLA: DETALLESDOCUMENTODMO **/
SELECT * FROM detallesDocumentoDmo
DELETE FROM detallesDocumentoDmo
DBCC CHECKIDENT ('detallesDocumentoDmo',RESEED,0)

/** MANEJO DE TABLA: PUNTOSMEDIDOSX **/
SELECT * FROM puntosMedidosX
DELETE FROM puntosMedidosX

/** MANEJO DE TABLA: PUNTOSMEDIDOSY **/
SELECT * FROM puntosMedidosY
DELETE FROM puntosMedidosY

/** MANEJO DE TABLA: PUNTOSMEDIDOSZ **/
SELECT * FROM puntosMedidosZ
DELETE FROM puntosMedidosZ

/** MANEJO DE TABLA: PUNTOSMEDIDOSD **/
SELECT * FROM puntosMedidosD
DELETE FROM puntosMedidosD
DBCC CHECKIDENT ('puntosMedidosD',RESEED,0)

/****/
/****/
/****/
/****/
/****/
/****/
/****/
/** PRUEBAS DE SENTENCIAS SQL PARA METER EN EL CODIGO DEL PROGRAMA PARA EL LLENADO DE TABLAS **/
SELECT DISTINCT d.codMedicion FROM detallesDocumentoDmo AS d, puntosMedidosD AS p WHERE d.idPtoMed='10106PSXYZ' AND d.codMedicion!=p.codMedicion

SELECT d.codMedicion FROM detallesDocumentoDmo AS d WHERE d.idPtoMed='10106PSXYZ' AND d.codMedicion NOT IN (SELECT codMedicion FROM puntosMedidosD) AND d.codMedicion NOT IN (SELECT codMedicion FROM puntosMedidosX)

SELECT * FROM puntosMedidosD WHERE codMediD='12100PS_XZ'
SELECT codMedicion FROM puntosMedidosD


SELECT * FROM controlPlan
DELETE FROM controlPlan
DBCC CHECKIDENT ('controlPlan',RESEED,0)

DELETE FROM imagenes
DBCC CHECKIDENT ('imagenes',RESEED,0)

SELECT * FROM detallesControlPlan
SELECT * FROM detallesControlPlan WHERE idPtoMed='10951GZ'
DELETE FROM detallesControlPlan
DBCC CHECKIDENT ('controlPlan',RESEED,0)

SELECT DISTINCT x.codDmo AS 'Control Plan', x.codMediX AS 'Punto', x.codMedicion AS 'ID Medici�n', x.medidoX AS 'Medido - X (mm)', y.medidoY AS 'Medido - Y (mm)', z.medidoZ AS 'Medido - Z (mm)',
x.desvX AS 'Desviaci�n - X (mm)', y.desvY AS 'Desviaci�n - Y (mm)', z.desvZ AS 'Desviaci�n - Z (mm)',
x.nominalX AS 'Nominal - X (mm)', y.nominalY AS 'Nominal - Y (mm)', z.nominalZ AS 'Nominal - Z (mm)'
FROM puntosMedidosX AS x, puntosMedidosY AS y, puntosMedidosZ AS z, puntosMedidosD AS d
WHERE x.codMediX = y.codMediY AND x.codMediX = z.codMediZ AND x.codDmo = y.codDmo AND x.codDmo = z.codDmo
ORDER BY x.codDmo ASC, x.codMedicion ASC

SELECT DISTINCT x.codDmo AS 'Control Plan', x.codMediX AS 'Punto', x.codMedicion AS 'ID Medici�n', x.medidoX AS 'Medido - X (mm)', y.medidoY AS 'Medido - Y (mm)', z.medidoZ AS 'Medido - Z (mm)',
x.desvX AS 'Desviaci�n - X (mm)', y.desvY AS 'Desviaci�n - Y (mm)', z.desvZ AS 'Desviaci�n - Z (mm)',
x.nominalX AS 'Nominal - X (mm)', y.nominalY AS 'Nominal - Y (mm)', z.nominalZ AS 'Nominal - Z (mm)'
FROM puntosMedidosX AS x, puntosMedidosY AS y, puntosMedidosZ AS z, puntosMedidosD AS d
WHERE x.codMediX = y.codMediY AND x.codMediX = z.codMediZ AND x.codDmo = y.codDmo AND x.codDmo = z.codDmo AND x.codDmo = 'L359016215PS300MM00560'
ORDER BY x.codMedicion ASC

SELECT DISTINCT x.codDmo AS 'Control Plan', x.codMediX AS 'Punto', x.codMedicion AS 'ID Medici�n', x.medidoX AS 'Medido - X (mm)', x.desvX AS 'Desviaci�n - X (mm)', x.nominalX AS 'Nominal - X (mm)'
FROM puntosMedidosX AS x
ORDER BY x.codMedicion ASC

-- PROBANDO BUSQUEDA DE INFORMACION DE VALORES DE UN PUNTO DETERMINADO --
SELECT dcp.idPtoMed AS 'Nombre Puntos (CP)', ddd.idPtoMed AS 'Puntos (DMO)', pmx.medidoX AS 'Medido en X'
FROM detallesControlPlan AS dcp, detallesDocumentoDmo AS ddd, puntosMedidosX AS pmx
WHERE dcp.clasiTipoPto = 'F' AND dcp.idPtoMed = ddd.idPtoMed AND pmx.codMedicion = ddd.codMedicion

SELECT DISTINCT ddd.idPtoMed FROM detallesDocumentoDmo AS ddd WHERE ddd.idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto='F')

SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto='F')

SELECT DISTINCT codDmo, codMediX, medidoX FROM puntosMedidosX WHERE codMediX = '14203Y'
UNION ALL
SELECT DISTINCT pmy.codDmo, codMediY, medidoY FROM puntosMedidosY AS pmy, puntosMedidosX WHERE codMediY = codMediX

SELECT pmx.codMediX, pmx.medidoX, pmy.medidoY, pmz.medidoZ
FROM puntosMedidosX AS pmx, puntosMedidosY AS pmy, puntosMedidosZ AS pmz
WHERE pmy.codMediY=pmz.codMediZ AND pmz.codMediZ=pmx.codMediX AND pmx.codMediX IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto='F'))


-- MANEJO DE ULTIMOS DMO USADOS O A USAR --

SELECT TOP 1 codDmo FROM documentosDmo ORDER BY codDmo DESC

SELECT TOP 3 codDmo FROM documentosDmo


SELECT * FROM muestras
DELETE FROM muestras
DBCC CHECKIDENT ('muestras',RESEED,0)

SELECT * FROM graficos
DELETE FROM graficos
DBCC CHECKIDENT ('graficos',RESEED,0)


SELECT * FROM detalleMuestras
DELETE FROM detalleMuestras
DBCC CHECKIDENT ('detalleMuestras',RESEED,0)


SELECT * FROM documentosDmo WHERE codDmo > 'L359016215PS300MM00560'

-- PROBANDO QUERYS PARA MUESTRAS --

SELECT m.codMuestra AS 'C�d. Muestra',m.fechaMuestra AS 'Fecha Muestra',dm.codDmo AS 'Doc. DMO', ddd.idPtoMed AS 'Nom. Punto',dcp.direcPtoMed AS 'Coord. Ppal.'
FROM muestras AS m,detalleMuestras AS dm,detallesDocumentoDmo AS ddd,detallesControlPlan AS dcp
WHERE m.codMuestra = dm.codMuestra AND dm.codDmo = ddd.codDmo AND ddd.idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')
AND ddd.idPtoMed = dcp.idPtoMed
ORDER BY m.codMuestra ASC,dm.codDmo ASC,ddd.idPtoMed ASC

SELECT m.codMuestra AS 'C�d. Muestra',m.fechaMuestra AS 'Fecha Muestra',dm.codDmo AS 'Doc. DMO',(SELECT COUNT(ddd.idPtoMed) FROM detallesDocumentoDmo AS ddd WHERE ddd.idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F') AND ddd.codDmo = dm.codDmo) AS 'Cant. Puntos'
FROM muestras AS m,detalleMuestras AS dm
WHERE m.codMuestra = dm.codMuestra
ORDER BY m.codMuestra ASC,dm.codDmo ASC

SELECT COUNT(ddd.idPtoMed) AS 'Cant. Puntos'
FROM detallesDocumentoDmo AS ddd
WHERE ddd.idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')
AND ddd.codDmo = 'L359016215PS300MM00560'

SELECT * FROM detallesDocumentoDmo

SELECT * FROM muestras WHERE NOT EXISTS (SELECT codMuestra FROM graficos)

SELECT codDmo AS 'Documento DMO' FROM detalleMuestras WHERE codMuestra = '1'

SELECT * FROM muestras

SELECT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra = '1')

--listado de puntos relacionados a una muestra X (Gestor de gr�ficos)
SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra = '1')
AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F'))


SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')


SELECT codDmo AS 'DocumentoDmo',upTolD AS 'Tolerancia Sup.',medidoD AS 'Medido',loTolD AS 'Tolerancia Inf.'
FROM puntosMedidosD 
WHERE codMediD IN 
(
SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra = '3')
AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F'))
AND idPtoMed = '10739XD'
)
AND codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra = '3')


--PROBANDO INNER JOIN--
SELECT z.DocumentoDmo,z.Punto,z.Fecha,z.Nominal,z.[Tolerancia Sup.],z.Medido,z.[Tolerancia Inf.],z.[Desviaci�n]
FROM
(

SELECT pmx.codDmo AS 'DocumentoDmo', pmx.codMediX AS 'Punto',dd.fechaDmo AS 'Fecha',pmx.nominalX AS 'Nominal',pmx.upTolX AS 'Tolerancia Sup.',pmx.medidoX AS 'Medido',pmx.loTolX AS 'Tolerancia Inf.',pmx.desvX AS 'Desviaci�n'
FROM puntosMedidosX AS pmx
INNER JOIN documentosDmo AS dd ON dd.codDmo = pmx.codDmo
WHERE pmx.codMediX IN 
(
SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN ('L359016215PS300MM00560','L359016215PS300MM00561','L359016215PS300MM00562')
AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan))
AND idPtoMed IN ('')
)
AND pmx.codDmo IN ('L359016215PS300MM00560','L359016215PS300MM00561','L359016215PS300MM00562')

UNION

SELECT pmy.codDmo AS 'DocumentoDmo', pmy.codMediY AS 'Punto',dd.fechaDmo AS 'Fecha',pmy.nominalY AS 'Nominal',pmy.upTolY AS 'Tolerancia Sup.',pmy.medidoY AS 'Medido',pmy.loTolY AS 'Tolerancia Inf.',pmy.desvY AS 'Desviaci�n'
FROM puntosMedidosY AS pmy
INNER JOIN documentosDmo AS dd ON dd.codDmo = pmy.codDmo
WHERE pmy.codMediY IN 
(
SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN ('L359016215PS300MM00560','L359016215PS300MM00561','L359016215PS300MM00562')
AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan))
AND idPtoMed IN ('10503Y')
)
AND pmy.codDmo IN ('L359016215PS300MM00560','L359016215PS300MM00561','L359016215PS300MM00562')

UNION

SELECT pmz.codDmo AS 'DocumentoDmo', pmz.codMediZ AS 'Punto',dd.fechaDmo AS 'Fecha',pmz.nominalZ AS 'Nominal',pmz.upTolZ AS 'Tolerancia Sup.',pmz.medidoZ AS 'Medido',pmz.loTolZ AS 'Tolerancia Inf.',pmz.desvZ AS 'Desviaci�n'
FROM puntosMedidosZ AS pmz
INNER JOIN documentosDmo AS dd ON dd.codDmo = pmz.codDmo
WHERE pmz.codMediZ IN 
(
SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN ('L359016215PS300MM00560','L359016215PS300MM00561','L359016215PS300MM00562')
AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan))
AND idPtoMed IN ('10745Z')
)
AND pmz.codDmo IN ('L359016215PS300MM00560','L359016215PS300MM00561','L359016215PS300MM00562')

UNION

SELECT pmd.codDmo AS 'DocumentoDmo',pmd.codMediD AS 'Punto',dd.fechaDmo AS 'Fecha',pmd.nominalD AS 'Nominal',pmd.upTolD AS 'Tolerancia Sup.',pmd.medidoD AS 'Medido',pmd.loTolD AS 'Tolerancia Inf.',pmd.desvD AS 'Desviaci�n'
FROM puntosMedidosD AS pmd
INNER JOIN documentosDmo AS dd ON dd.codDmo = pmd.codDmo
WHERE pmd.codMediD IN 
(
SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN ('L359016215PS300MM00560','L359016215PS300MM00561','L359016215PS300MM00562')
AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan))
AND idPtoMed IN ('10739XD')
)
AND pmd.codDmo IN ('L359016215PS300MM00560','L359016215PS300MM00561','L359016215PS300MM00562')

) AS z
ORDER BY z.Punto, z.DocumentoDmo

SELECT * FROM muestras

SELECT * FROM detalleMuestras


SELECT DISTINCT ddd.idPtoMed AS 'Puntos de Medici�n',dcp.clasiTipoPto AS 'Tipo de Punto'
FROM detallesDocumentoDmo AS ddd
INNER JOIN detallesControlPlan AS dcp ON dcp.idPtoMed = ddd.idPtoMed
WHERE ddd.codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra ='3')
	AND ddd.idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan))

-- probando querys para calculos --

SELECT pmd.desvD AS 'Desviaci�n'
FROM puntosMedidosD AS pmd
INNER JOIN documentosDmo AS dd ON dd.codDmo = pmd.codDmo
WHERE pmd.codMediD IN 
(
SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra = '3')
AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F'))
AND idPtoMed = '10739XD'
)
AND pmd.codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra = '3')

SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo = 'L359016215PS300MM00560' OR codDmo = 'L359016215PS300MM00561'

INSERT INTO tiposGrafico VALUES ('Muestras'),('Cálculos'),('Personalizado')

SELECT * FROM graficos

SELECT * FROM tiposUsuario
DELETE FROM tiposUsuario WHERE codTipoUsu >= 4
DBCC CHECKIDENT ('tiposUsuario',RESEED,3)

INSERT INTO tiposUsuario VALUES ('Usuario PPS')

SELECT * FROM usuarios
DELETE FROM usuarios WHERE codUsu >= 6
DBCC CHECKIDENT ('usuarios',RESEED,5)

SELECT * FROM aprobadores

SELECT * FROM compiladores

SELECT * FROM operariosMaquina

SELECT * FROM estados
DELETE FROM estados WHERE codEstado >= 3
DBCC CHECKIDENT ('estados',RESEED,2)
