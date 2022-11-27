using Microsoft.JSInterop;

namespace MastoGraph; 

public class LocalStorage : IAsyncDisposable {
	private Lazy<IJSObjectReference> _accessorJsRef = new();
	private readonly IJSRuntime _jsRuntime;

	public LocalStorage(IJSRuntime jsRuntime) {
		_jsRuntime = jsRuntime;
	}

	private async Task WaitForReference() {
		if (_accessorJsRef.IsValueCreated is false) {
			_accessorJsRef = new Lazy<IJSObjectReference>(
				await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "/js/LocalStorage.js"));
		}
	}

	public async ValueTask DisposeAsync() {
		if (_accessorJsRef.IsValueCreated) {
			await _accessorJsRef.Value.DisposeAsync();
		}
		GC.SuppressFinalize(this);
	}

	// ------------------------------------------------------
	
	public async Task ClearAsync() {
		await WaitForReference();
		await _accessorJsRef.Value.InvokeVoidAsync("clear");
	}
	
	public async Task RemoveValueAsync(string key) {
		await WaitForReference();
		await _accessorJsRef.Value.InvokeVoidAsync("remove", key);
	}
	
	public async Task<T> GetValueAsync<T>(string key) {
		await WaitForReference();
		return await _accessorJsRef.Value.InvokeAsync<T>("get", key);
	}

	public async Task SetValueAsync<T>(string key, T value) {
		await WaitForReference();
		await _accessorJsRef.Value.InvokeVoidAsync("set", key, value);
	}
}