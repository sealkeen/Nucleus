import { __decorate } from "tslib";
import { Component } from 'vue-property-decorator';
import NucleusComponentBase from '@/shared/application/nucleus-component-base';
let ListComponent = class ListComponent extends NucleusComponentBase {
    loading = true;
    search = '';
    options = {};
    pagedListOfNewsListDto = {
        totalCount: 0,
        items: []
    };
    mounted() {
        this.getNews();
    }
    getNews() {
        this.loading = true;
        this.nucleusService.get('/api/News/GetNews', false).then((response) => {
            this.pagedListOfNewsListDto = response.content;
            this.loading = false;
        });
    }
};
ListComponent = __decorate([
    Component
], ListComponent);
export default ListComponent;
//# sourceMappingURL=news-list.js.map