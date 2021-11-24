import { __decorate } from "tslib";
import { Component } from 'vue-property-decorator';
import NucleusComponentBase from '@/shared/application/nucleus-component-base';
let ForgotPasswordComponent = class ForgotPasswordComponent extends NucleusComponentBase {
    refs = this.$refs;
    forgotPasswordInput = {};
    errors = [];
    isEmailSent = false;
    resultMessage;
    onSubmit() {
        if (this.refs.form.validate()) {
            this.nucleusService.post('/api/forgotPassword', this.forgotPasswordInput)
                .then((response) => {
                if (!response.isError) {
                    this.resultMessage = this.$t('EMailSentSuccessfully').toString();
                    this.isEmailSent = true;
                }
                else {
                    this.errors = response.errors;
                }
            });
        }
    }
};
ForgotPasswordComponent = __decorate([
    Component
], ForgotPasswordComponent);
export default ForgotPasswordComponent;
//# sourceMappingURL=forgot-password.js.map