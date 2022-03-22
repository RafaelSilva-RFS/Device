export class LocalStorageUtils {
    
    public obterUsuario() {
        return JSON.parse(localStorage.getItem('deviceapp.user'));
    }

    public salvarDadosLocaisUsuario(response: any) {
        this.salvarTokenUsuario(response.accessToken);
        this.salvarUsuario(response.usuarioToken);
    }

    public limparDadosLocaisUsuario() {
        localStorage.removeItem('deviceapp.token');
        localStorage.removeItem('deviceapp.user');
    }

    public obterTokenUsuario(): string {
        return localStorage.getItem('deviceapp.token');
    }

    public salvarTokenUsuario(token: string) {
        localStorage.setItem('deviceapp.token', token);
    }

    public salvarUsuario(user: string) {
        localStorage.setItem('deviceapp.user', JSON.stringify(user));
    }

}