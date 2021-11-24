import { __decorate } from "tslib";
import { Component } from 'vue-property-decorator';
import NucleusComponentBase from '@/shared/application/nucleus-component-base';
let NewsCreateComponent = class NewsCreateComponent extends NucleusComponentBase {
    refs = this.$refs;
    createNewsInput = {};
    errors = [];
    resultMessage;
    creationNewsIsComplete = false;
    onSubmit() {
        if (this.refs.form.validate()) {
            this.nucleusService.post('/api/news/PostNews', this.createNewsInput)
                .then((response) => {
                if (!response.isError) {
                    this.resultMessage = this.$t('NewsCreationSuccessful').toString();
                    this.creationNewsIsComplete = true;
                }
                else {
                    this.errors = response.errors;
                }
            });
        }
    }
};
NewsCreateComponent = __decorate([
    Component
], NewsCreateComponent);
export default NewsCreateComponent;
//# sourceMappingURL=create-news.js.map