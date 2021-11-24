export default class LanguageStore {
    static storageKey = 'language';
    static getLanguage() {
        return JSON.parse(localStorage.getItem(LanguageStore.storageKey)) ||
            { languageCode: 'en', languageName: 'English' };
    }
    static setLanguage(input) {
        localStorage.setItem(LanguageStore.storageKey, JSON.stringify(input));
    }
    static removeLanguage() {
        localStorage.removeItem(LanguageStore.storageKey);
    }
}
//# sourceMappingURL=language-store.js.map