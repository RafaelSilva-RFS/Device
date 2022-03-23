describe('Dashboard', () => {

    var identityBaseUrl = "https://localhost:44336//api/v1/identity/"
    var devicesApiBaseUrl = "https://localhost:44363/api/v1/"

    beforeEach(() => {
        Cypress.Cookies.debug(true)

        cy.clearCookies();

        cy.intercept(identityBaseUrl + '*').as('authLogin')

        cy.visit('http://localhost:4200/account/login')
            .get('input').clear();

        cy.get('#email').click().type('admin@device.com');
        cy.get('#password').click().type('1q2w3E*');
        cy.get('#Login').click();

        cy.wait(['@authLogin']);
    })


    it('Should show top info cards', function() {
        cy.get('app-card-dashboard .card-body p').should('be.visible');
    });

    it('Should show most used devices', function() {
        cy.get('#most-used-devices-box .device-detail-row').should('be.visible');
    });

    it('IF there is offline devices should show offline devices rows', function() {
        cy.get('#offline-devices-box .device-detail-row').should('be.visible');
    });


});