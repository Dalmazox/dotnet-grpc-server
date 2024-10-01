proto:
	rm -rf ./src/ProtoSharp.WebApi/Generated
	buf dep update
	buf generate
.PHONY: proto
