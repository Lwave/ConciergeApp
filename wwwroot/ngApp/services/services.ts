namespace ConciergeApp.Services {
    export class OpenModalService {
        constructor(public $uibModal: ng.ui.bootstrap.IModalService) { }
        public openModal(html, feedbackId = 0, commentId = 0) {
            console.log(2);
            this.$uibModal.open({
                templateUrl: `/ngApp/views/${html}`,
                controller: ConciergeApp.Controllers.ModalController,
                controllerAs: "modal",
                resolve: {
                    feedbackId: () => feedbackId,
                    commentId: () => commentId,
                },
                size: 'md'
            })
        }
    }

    angular.module('ConciergeApp').service("OpenModalService", OpenModalService);
}
    
