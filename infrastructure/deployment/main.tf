module "application_server" {
  source = "../modules/hetzner-compose-application"

  admin_ssh_key    = "ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIJTb0amZOk5RWZrW7dJ0+4RLS9jtfhq8bug1ym1kx61o"
  application_name = "our-app"

  git_repository_url      = "https://github.com/LarsGJobloop/2026-02-backend-advanced.git"
  compose_file_path       = "compose.yaml"
  git_repository_branch   = "main"
  reconciliation_interval = "30s"

  server_location = "hel1"
  server_type     = "cax41"
}

output "app" {
  description = "All the necessary details for the application"
  value       = module.application_server
}
