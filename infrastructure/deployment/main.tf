module "application_server" {
  source = "../modules/hetzner-compose-application"

  name = "out-app"

  source_repo  = "https://github.com/LarsGJobloop/2026-02-backend-advanced"
  compose_path = "compose.prod.yaml"
}

output "app" {
  description = "All the necessary details for the application"
  value       = module.application_server
}
