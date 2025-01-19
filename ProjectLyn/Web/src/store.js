import {readable, writable} from 'svelte/store';

export const SceneEnum = {
    Login: 0,
    Menu: 1,
}

export let storeGlobalInfo = writable({
    Scene: SceneEnum.Login,

    GetAdminServerUrl(apiUrl) 
    {
        return `http://${network['Host']}:${network['Port']}/InHouse/${apiUrl}`;
    },


    //https://svelte.dev/tutorial/kit/post-handlers

    async PostApiAsync(apiUrl, request, cb)
    {
        return await InternalSendApiAsync(apiUrl, 'post', request, cb);
    },

    async GetApiAsync(apiUrl, request, cb)
    {
        return await InternalSendApiAsync(apiUrl, 'get', request, cb);
    },

    // send api
    async InternalSendApiAsync(apiUrl, meth, request, cb)
    {
        var url = self.GetAdminServerUrl(apiUrl);
        const response = await fetch(url, {
			method: meth,
			body: request, //JSON.stringify({ request }),
			headers: {
				'Content-Type': 'application/json'
			}
		});
        cb(response.body);
    }
});