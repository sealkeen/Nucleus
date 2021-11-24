import { __decorate } from "tslib";
import { Component } from 'vue-property-decorator';
import NucleusComponentBase from '@/shared/application/nucleus-component-base';
let RegisterComponent = class RegisterComponent extends NucleusComponentBase {
    refs = this.$refs;
    registerInput = {};
    errors = [];
    resultMessage;
    registerComplete = false;
    onSubmit() {
        if (this.refs.form.validate()) {
            this.nucleusService.post('/api/register', this.registerInput)
                .then((response) => {
                if (!response.isError) {
                    this.resultMessage = this.$t('AccountCreationSuccessful').toString();
                    this.registerComplete = true;
                }
                else {
                    this.errors = response.errors;
                }
            });
        }
    }
};
RegisterComponent = __decorate([
    Component
], RegisterComponent);
export default RegisterComponent;
//# sourceMappingURL=register.js.map