using ProtoSharp.WebApi.Generated.Account.V1;
using Grpc.Core;
using Base = ProtoSharp.WebApi.Generated.Account.V1.AccountService.AccountServiceBase;

namespace ProtoSharp.WebApi.Services;

public class AccountService : Base
{
	public override Task<OpenAccountResponse> OpenAccount(OpenAccountRequest request, ServerCallContext context)
	{
		var response = new OpenAccountResponse()
		{
			AccountId = Guid.NewGuid().ToString(),
			Balance = request.InitialBalance
		};

		return Task.FromResult(response);
	}
}
