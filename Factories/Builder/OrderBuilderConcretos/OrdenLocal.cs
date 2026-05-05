public class OrdenLocal : IOrdenBuilder {
    private OrdenDespacho orden = new OrdenDespacho();

    public void generarId() { orden.asignarId("LOC-" + Guid.NewGuid().ToString().Substring(0, 5)); }
    
    public void añadirDescripcion() { orden.asignarDescripcion("Envío de distribución local."); }

    public void añadirDocumentacionAduanera() {
        orden.asignarAduana("No requiere documentación internacional.");
    }

    public void añadirSeguroTransito() {
        orden.asignarSeguro("Seguro básico contra accidentes.");
    }

    public OrdenDespacho obtenerOrden() { return orden; }

    public void asignarRuta(IComponenteRuta ruta)
    {
        throw new NotImplementedException();
    }
}

