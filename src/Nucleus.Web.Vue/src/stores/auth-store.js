export default class AuthStore {
    static storageKey = 'token';
    static getToken() {
        return localStorage.getItem(AuthStore.storageKey);
    }
    static setToken(token) {
        localStorage.setItem(AuthStore.storageKey, token);
    }
    static removeToken() {
        localStorage.removeItem(AuthStore.storageKey);
    }
    static isSignedIn() {
        return !!AuthStore.getToken();
    }
    static getTokenData() {
        const token = AuthStore.getToken();
        if (token) {
            return JSON.parse(atob(token.split('.')[1]));
        }
        return {};
    }
}
//# sourceMappingURL=auth-store.js.map