// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
self.addEventListener('fetch', (event) => { 
    if (event.request.method === 'POST' && url.pathname === '/') {
        event.respondWith((async () => {
            const formData = await event.request.formData();
            const link = formData.get('link') || formData.get('text');
            if (link) {
                const instance = new URL(link).host;
                const components = link.split("/");
                const statusId = components[components[components.length - 1]];
                return Response.redirect("/" + instance + "/" + statusId, 303);
            }
        })());
    }
});
