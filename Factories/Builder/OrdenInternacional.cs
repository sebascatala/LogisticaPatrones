public class OrdenInternacional : IOrdenBuilder {
    private OrdenDespacho orden = new OrdenDespacho();

    public void generarId() { orden.asignarId("INT-" + Guid.NewGuid().ToString().Substring(0, 5)); }

    public void añadirDescripcion() { orden.asignarDescripcion("Tránsito internacional transfronterizo."); }

    public void añadirDocumentacionAduanera() {
        orden.asignarAduana("Factura comercial, Packing List y Certificado de Origen.");
    }

    public void añadirSeguroTransito() {
        orden.asignarSeguro("Seguro de carga internacional todo riesgo.");
    }

    public OrdenDespacho obtenerOrden() { return orden; }
}