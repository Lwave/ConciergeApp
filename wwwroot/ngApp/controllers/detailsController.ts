namespace ConciergeApp.Controllers {

    export class DetailsController {
        public business;
        public feedback;
        public details;
        constructor(public $http: ng.IHttpService, public OpenModalService: ConciergeApp.Services.OpenModalService) {
            this.$http.post('api/details/search', { placeid: localStorage['placeid'] }).then((res) => {
                this.details = res.data;
                console.info(this.details);
            });
        }
    


        public openModal(html) {
            this.OpenModalService.openModal(html, this.business.id);
        }
    }
    //export class DetailsController {
    //    constructor(public $uibModal: ng.ui.bootstrap.IModalService, public OpenModalService: ConciergeApp.Services.OpenModalService) {
    //    }

    //    public openModal(html, feedbackId) {
    //        console.log(1);
    //        this.OpenModalService.openModal(html,feedbackId);
    //    }
    //}

}