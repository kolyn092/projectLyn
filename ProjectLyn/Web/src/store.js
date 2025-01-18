import {readable, writable} from 'svelte/store';

export const SceneEnum = {
    Login: 0,
    Menu: 1,
}

export let storeGlobalInfo = writable({
    Scene: SceneEnum.Login,

    //Admin 서버 API 주소가져오기
    GetAdminServerUrl(apiUrl, isAdmin) {
        if (isAdmin) {
            return `http://${network["Host"]}:${network["Port"]}/Admin/${apiUrl}`;
        }
        else {
            return `http://${network["Host"]}:${network["Port"]}/InHouse/${apiUrl}`;
        }
    },

    // get api

    // send api
});