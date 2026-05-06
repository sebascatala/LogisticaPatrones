public interface IOrdenBuilder {
    void generarId();
    void añadirDescripcion();
    void añadirDocumentacionAduanera();
    void añadirSeguroTransito();
    OrdenDespacho obtenerOrden();
}