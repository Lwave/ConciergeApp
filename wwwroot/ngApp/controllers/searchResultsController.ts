namespace ConciergeApp.Controllers {
    export class SearchResultsController {
        public places;
        public result1;
        public options1;
        public details1;
        public result2;
        public options2;
        public details2;

        constructor(public $http: ng.IHttpService, public $state: ng.ui.IStateService) {
            this.$http.post('api/places/search', { search: localStorage['keyword'], location: localStorage['loc'] }).then((res) => {
                this.places = res.data;
                console.info(this.places);
            });
            this.result1 = '';
            this.options1 = null;
            this.details1 = '';
            this.result2 = '';
            this.options2 = 'types = establishment';
            this.details2 = '';
        }
        public savePlace(placeid) {
            localStorage['placeid'] = placeid;
            console.log(placeid);
            this.$state.go('details');
        }
    }
}
