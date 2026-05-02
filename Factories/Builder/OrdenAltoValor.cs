public class OrdenAltoValor {
    public string id;
    public string descripcion;
    public string instruccionesManejo;
    public string documentacionAduana;
    public string seguroTransito;
    public double valorDeclarado;

    public void asignarId(string id) { this.id = id; }
    public void asignarDescripcion(string desc) { this.descripcion = desc; }
    public void asignarInstruccion(string inst) { this.instruccionesManejo = inst; }
    public void asignarAduana(string doc) { this.documentacionAduana = doc; }
    public void asignarSeguro(string seg) { this.seguroTransito = seg; }
    public void asignarValorDeclarado(double valor) { this.valorDeclarado = valor; }
}