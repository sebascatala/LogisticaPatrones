public class OrdenAltoValor : IOrdenBuilder {
    private OrdenDespacho _orden = new OrdenDespacho();

    public void generarId() { 
        _orden.asignarId("AV-" + Guid.NewGuid().ToString().Substring(0, 5)); 
    }

    public void añadirDescripcion() { 
        _orden.asignarDescripcion("Carga de alto valor económico/legal."); 
    }

    public void añadirDocumentacionAduanera() {
        // El enunciado dice que si cruza fronteras lleva esto, pero para el ejemplo lo asignamos siempre porque es un requisito de alto valor
        _orden.asignarAduana("Declaración de valor y permisos especiales.");
    }

    public void añadirSeguroTransito() {
        // REQUISITO: La orden de alto valor TIENE seguro de tránsito
        _orden.asignarSeguro("Seguro Premium: Cobertura del 100% contra robo y pérdida.");
    }

    public OrdenDespacho obtenerOrden() => _orden;

}