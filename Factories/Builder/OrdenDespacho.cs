public class OrdenDespacho {
    public string id = string.Empty;
    public string descripcion = string.Empty;
    public string instruccionesManejo = string.Empty;
    public IComponenteRuta RutaAsignada { get; set; }
    public string documentacionAduana = string.Empty;
    public string seguroTransito = string.Empty;

    public void asignarId(string id) { this.id = id; }
    public void asignarDescripcion(string desc) { this.descripcion = desc; }
    public void asignarInstruccion(string inst) { this.instruccionesManejo = inst; }
    public void asignarAduana(string doc) { this.documentacionAduana = doc; }
    public void asignarSeguro(string seg) { this.seguroTransito = seg; }
    public bool EsValida() {
        // Lógica de negocio: Toda orden DEBE tener ID y Descripción
        return !string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(descripcion);
    }
}