import { __decorate } from "tslib";
import { Component } from 'vue-property-decorator';
import NucleusComponentBase from '@/shared/application/nucleus-component-base';
let ExceptionsListComponent = class ExceptionsListComponent extends NucleusComponentBase {
    loading = true;
    search = '';
    options = {};
    pagedListOfExceptionsListDto = {
        totalCount: 0,
        items: []
    };
    mounted() {
        this.getExceptions();
    }
    getExceptions() {
        this.loading = true;
        this.nucleusService.get('/api/Exception', false).then((response) => {
            this.pagedListOfExceptionsListDto = response.content;
            this.loading = false;
        });
    }
};
ExceptionsListComponent = __decorate([
    Component
], ExceptionsListComponent);
export default ExceptionsListComponent;
//# sourceMappingURL=exceptions-list.js.map