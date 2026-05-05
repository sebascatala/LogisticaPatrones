public interface IOrdenBuilder {
    void generarId();
    void añadirDescripcion();
    void asignarRuta(IComponenteRuta ruta);
    void añadirDocumentacionAduanera();
    void añadirSeguroTransito();
    OrdenDespacho obtenerOrden();
}