import { __decorate } from "tslib";
import { Component } from 'vue-property-decorator';
import NucleusComponentBase from '@/shared/application/nucleus-component-base';
let LoginComponent = class LoginComponent extends NucleusComponentBase {
    refs = this.$refs;
    loginInput = {};
    errors = [];
    onSubmit() {
        if (this.refs.form.validate()) {
            this.nucleusService.post('/api/login', this.loginInput)
                .then((response) => {
                if (!response.isError) {
                    this.authStore.setToken(response.content.token);
                    this.$router.push({ path: '/home' });
                }
                else {
                    this.errors = response.errors;
                }
            });
        }
    }
};
LoginComponent = __decorate([
    Component
], LoginComponent);
export default LoginComponent;
//# sourceMappingURL=login.js.map